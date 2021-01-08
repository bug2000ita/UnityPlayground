using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateControllerScipt : MonoBehaviour
{
    Animator animator;
    float velocity = 0.0f;
    public float acceleration = 0.1f;
    public float deceleration = 1.5f;
    int velocityHash;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        velocityHash = Animator.StringToHash("Speed");
        //isWalkingHash = Animator.StringToHash("isWalking");
        //isRunningHash = Animator.StringToHash("isRunning");
    }

    // Update is called once per frame
    void Update()
    {
        //bool isWalking = animator.GetBool(isWalkingHash);
        //bool isRunning = animator.GetBool(isRunningHash);
        bool isForwardPressed = Input.GetKey("w");
        bool isRunPressed = Input.GetKey("space"); ;


        if(isForwardPressed && velocity <1.0f)
        {
            velocity += Time.deltaTime * 8 * acceleration;
        }
        if(!isForwardPressed && velocity > 0.1f)
        {
            velocity -= Time.deltaTime * deceleration;
        }

        if (!isForwardPressed && velocity < 0.1f)
        {
            velocity = 0;
        }



        animator.SetFloat(velocityHash, velocity);

        /*
         
        if(!isWalking && !isRunPressed && isForwardPressed)
        {
            animator.SetBool(isWalkingHash,true);
        }

        if(isWalking && !isForwardPressed)
        {
            animator.SetBool(isWalkingHash,false);
        }

        if(isWalking && isRunPressed && isForwardPressed)
        {
            animator.SetBool(isRunningHash,true);
        }

        if (isRunning && (!isRunPressed || !isForwardPressed))
        {
            animator.SetBool(isRunningHash, false);
        }
        */

    }
}
