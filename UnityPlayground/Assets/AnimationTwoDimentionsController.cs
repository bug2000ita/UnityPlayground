using System;
using UnityEngine;

public class AnimationTwoDimentionsController : MonoBehaviour
{
    Animator animator;
    float velocityZ = 0.0f;
    float velocityX = 0.0f;

    public float acceleration = 2.0f;
    public float deceleration = 2.0f;

    float maximumWalkVelocity = 0.5f;
    float maximumRunVelocity = 2.0f;

    int velocityXHash;
    int velocityZHash;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        velocityXHash = Animator.StringToHash("Velocity X");
        velocityZHash = Animator.StringToHash("Velocity Z");
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
                isAxisDirectionPositive?
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

    // Update is called once per frame
    void Update()
    {
        // evaluate state of key

        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool rightPressed = Input.GetKey(KeyCode.D);
        bool leftPressed = Input.GetKey(KeyCode.A);
        bool backwardPressed = Input.GetKey(KeyCode.S);
        bool runpressed = Input.GetKey(KeyCode.LeftShift);

        // 
        float maxVelocity = runpressed ? maximumRunVelocity : maximumWalkVelocity;

        velocityZ = forwardPressed ?
            EstimateVelocityWhenKeyPressed(velocityZ, maxVelocity, AxisDirection.Positive):
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

    }

    private enum AxisDirection
    { 
        Negative = -1,
        Positive = 1
    }
       

}


