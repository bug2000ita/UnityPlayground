using System;
using System.Collections.Generic;
using Cinemachine;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class MovePlayer : MonoBehaviour
{
    Animator animator;
    float velocityZ = 0.0f;
    float velocityX = 0.0f;

    

    [SerializeField] private float walkSpeedPlayer = 10f;
    [SerializeField] private float maxSpeedPlayer = 15f;
    private float speedPlayer = 0;

    private CharacterController characterController;

    public float acceleration = 2.0f;
    public float deceleration = 2.0f;

    float maximumWalkVelocity = 0.5f;
    float maximumRunVelocity = 2.0f;

    int velocityXHash;
    int velocityZHash;
    int jumpHash;

    bool isWalking = false;
    bool isrunning = false;

    InputController inputController;

    List<Vector3> Positions;

    bool forwardPressed;
    bool rightPressed;
    bool leftPressed;
    bool backwardPressed;
    bool runPressed;


    bool jumpPressed;

    bool collitionStop = false;

    Transform lastTransform;

    private float verticalSpeed = 0;

    private GameObject camera;
    private Rigidbody playerRB;
    public GameObject focal;
    public GameObject centerOfMass;

    private bool isGrounded = false; 

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;


    }


    private void OnCollisionExit(Collision other)
    {
        isGrounded = false;
    }





    //Awake

    private void Awake()
    {
        Positions = new List<Vector3>();
        inputController = new InputController();
        inputController.CharacterInput.UpButton.performed += ctx =>  forwardPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.DownButton.performed += ctx => backwardPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.RightButton.performed += ctx => rightPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.LeftButton.performed += ctx => leftPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.RunButton.performed += ctx => runPressed = ctx.ReadValueAsButton();

        inputController.CharacterInput.JumpButton.performed += ctx => jumpPressed = ctx.ReadValueAsButton();

    }

    private void OnEnable()
    {
        inputController.CharacterInput.Enable();
    }

    private void OnDisable()
    {
        inputController.CharacterInput.Disable();
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerRB = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
        camera = GameObject.Find("PlayerCamera");
        playerRB.centerOfMass = centerOfMass.transform.position;


        velocityXHash = Animator.StringToHash("Velocity X");
        velocityZHash = Animator.StringToHash("Velocity Z");
        jumpHash = Animator.StringToHash("isJumping");

    }


    private void DetermineState()
    {
        if (Math.Abs(velocityZ) < maximumWalkVelocity || Math.Abs(velocityX) < maximumWalkVelocity)
        {
            isWalking = true;
            isrunning = false;
        }

        if (Math.Abs(velocityZ) > maximumWalkVelocity || Math.Abs(velocityX) > maximumWalkVelocity)
        {
            isWalking = false;
            isrunning = true;
        }

        if (Math.Abs(velocityZ) == 0 && Math.Abs(velocityX) == 0)
        {
            isWalking = false;
            isrunning = false;
        }


    }


private void handleMovement()
    {
        DetermineState();

        Physics.gravity = new Vector3(0, -100.0F, 0);

        if (!collitionStop)
        {
            lastTransform = this.GetComponent<Rigidbody>().transform;
            //Debug.Log($"LAST VALUE ****  {lastTransform.position.x} " +
            //    $"{lastTransform.position.y} " +
            //    $"{lastTransform.position.z}");

            Positions.Add(lastTransform.position);
        }


        if (runPressed)
        {
            speedPlayer = speedPlayer<maximumRunVelocity ? speedPlayer+ 0.001f : maxSpeedPlayer;

            Debug.Log("SPEED" + speedPlayer);
            
        }
        else
        {
            speedPlayer = walkSpeedPlayer;
        }

        if (jumpPressed && isGrounded)
        {
            playerRB.AddForce(transform.up * 50, ForceMode.Impulse);
            Debug.Log("Jump Pressed");

        }

        if (forwardPressed)
        {
            playerRB.AddForce(focal.transform.forward * speedPlayer, ForceMode.Impulse);

        }

        if (backwardPressed)
        {
            playerRB.AddForce(-focal.transform.forward * speedPlayer, ForceMode.Impulse);
        }

        if (leftPressed)
        {
            transform.Rotate(Vector3.up, -180 * Time.deltaTime);
        }

        if (rightPressed)
        {
            transform.Rotate(Vector3.up, 180 * Time.deltaTime);
        }

        
    }

    private bool IsAxisDirectionPositive(AxisDirection axisDirection)
    {
        //Check if we have positive 2D direction.
        //In this set:
        //- pressing forward and right key we have positve values
        //- pressing left key we  have negative values

        return axisDirection == AxisDirection.Positive;
    }

    private float EstimateVelocityWhenKeyPressed(float outputVelocity, float currentMaxVelocity, AxisDirection axisDirection)
    {
        // identify type of logic to be used for incrementing / decrementing values
        bool isAxisDirectionPositive = IsAxisDirectionPositive(axisDirection);

        // Increase value when key is pressed till the limit
        if (Math.Abs(outputVelocity) < currentMaxVelocity)
        {
            outputVelocity =
                isAxisDirectionPositive ?
                outputVelocity + Time.deltaTime * acceleration :
                outputVelocity - Time.deltaTime * acceleration;
        }

        // Decrease value when key is still pressed and max velocity changed
        // releasing the key associated for running
        else if (Math.Abs(outputVelocity) > currentMaxVelocity)
        {
            outputVelocity =
                isAxisDirectionPositive ?
                outputVelocity - Time.deltaTime * deceleration :
                outputVelocity + Time.deltaTime * deceleration;

            // when in range of max velocity after transition with deceleration
            // it sets the value equal to max speed allowed
            if (
                (Math.Abs(outputVelocity) > currentMaxVelocity - 0.05f)
                &&
                (Math.Abs(outputVelocity) < currentMaxVelocity + 0.05f))
            {
                int multiplier = isAxisDirectionPositive ? 1 : -1;
                outputVelocity = multiplier * currentMaxVelocity;
            }
        }

        return outputVelocity;
    }

    private float EstimateVelocityWhenKeyReleased(float currentVelocity, AxisDirection axisDirection)
    {
        // Target to reach at the end of deceleration when released key
        float targetDeceleration = 0.0f;

        // identify type of logic to be used for incrementing / decrementing values
        bool isAxisDirectionPositive = IsAxisDirectionPositive(axisDirection);


        // evaluate if we are above the threasold to allow deceleration
        bool isVelocityAboveTarget =
            isAxisDirectionPositive ?
            currentVelocity > targetDeceleration :
            currentVelocity < targetDeceleration;

        // decrease module of the velocity to reach the target
        if (isVelocityAboveTarget)
        {
            currentVelocity =
                isAxisDirectionPositive ?
                currentVelocity - Time.deltaTime * deceleration :
                currentVelocity + Time.deltaTime * deceleration;
        }

        // Check if value overshoot target value and set to extact target value
        bool isVelocityOvershootingTargetValue =
            isAxisDirectionPositive ?
            currentVelocity > targetDeceleration :
            currentVelocity < targetDeceleration;

        if (isVelocityOvershootingTargetValue)
        {
            currentVelocity = targetDeceleration;
        }

        return currentVelocity;
    }

    private void FixedUpdate()
    {
        handleMovement();
    }

    // Update is called once per frame
    void Update()
    {


        float maxVelocity = runPressed ? maximumRunVelocity : maximumWalkVelocity;

        velocityZ = forwardPressed ?
            EstimateVelocityWhenKeyPressed(velocityZ, maxVelocity, AxisDirection.Positive) :
            EstimateVelocityWhenKeyReleased(velocityZ, AxisDirection.Positive);

        velocityZ = backwardPressed ?
            EstimateVelocityWhenKeyPressed(velocityZ, maxVelocity, AxisDirection.Negative) :
            EstimateVelocityWhenKeyReleased(velocityZ, AxisDirection.Negative);

        velocityX = rightPressed ?
            EstimateVelocityWhenKeyPressed(velocityX, maxVelocity, AxisDirection.Positive) :
            EstimateVelocityWhenKeyReleased(velocityX, AxisDirection.Positive);

        velocityX = leftPressed ?
            EstimateVelocityWhenKeyPressed(velocityX, maxVelocity, AxisDirection.Negative) :
            EstimateVelocityWhenKeyReleased(velocityX, AxisDirection.Negative);


        animator.SetFloat(velocityXHash, velocityX);
        animator.SetFloat(velocityZHash, velocityZ);

        if(jumpPressed)
        {
            animator.SetBool(jumpHash, true);
        }
        else
        {
            animator.SetBool(jumpHash, false);
        }

    }



    private enum AxisDirection
    {
        Negative = -1,
        Positive = 1
    }


   

}


