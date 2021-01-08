using System;
using System.Collections;
using System.Collections.Generic;
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

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private float drive(bool directionButtonPressed, float outputVelocity, float currentMaxVelocity, bool signPositive)
    {
        if (directionButtonPressed && Math.Abs(outputVelocity) < currentMaxVelocity)
        {
            outputVelocity = signPositive ? outputVelocity + Time.deltaTime * acceleration : outputVelocity - Time.deltaTime * acceleration;
        }
        else if (directionButtonPressed && Math.Abs(outputVelocity) > currentMaxVelocity)
        {
            outputVelocity = signPositive ? outputVelocity - Time.deltaTime * deceleration : outputVelocity + Time.deltaTime * deceleration;

            if (Math.Abs(outputVelocity) > currentMaxVelocity - 0.1f && Math.Abs(outputVelocity) < currentMaxVelocity + 0.1f)
            {
                int multiplier = signPositive ? 1 : -1;
                outputVelocity = multiplier * currentMaxVelocity;
            }
        }

        return outputVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool rightPressed = Input.GetKey("d");
        bool leftPressed = Input.GetKey("a");
        bool runpressed = Input.GetKey("left shift");



        float currentMaxVelocity = runpressed ? maximumRunVelocity : maximumWalkVelocity;

        velocityZ = drive(forwardPressed, velocityZ, currentMaxVelocity,true);
        velocityX = drive(rightPressed, velocityX, currentMaxVelocity, true);
        velocityX = drive(leftPressed, velocityX, currentMaxVelocity, false);




       
        if (!forwardPressed && (velocityZ > 0))
        {
            velocityZ -= Time.deltaTime * deceleration;
        }

        if (!forwardPressed && velocityZ < 0)
        {
            velocityZ = 0;
        }
        

        if (!leftPressed &&  velocityX < 0)
        {
            velocityX += Time.deltaTime * deceleration;
        }

        if (!rightPressed  && velocityX > 0)
        {
            velocityX -= Time.deltaTime * deceleration;
        }

        
        bool velocityRange = (velocityX > -0.05) && (velocityX < 0.05);

        if (!leftPressed && !rightPressed && velocityRange)
        {
            velocityX = 0;
        }




        animator.SetFloat("Velocity X", velocityX);
        animator.SetFloat("Velocity Z", velocityZ);

    }
}
