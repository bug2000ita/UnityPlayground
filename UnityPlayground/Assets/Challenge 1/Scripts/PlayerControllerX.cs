using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 2;
    public float rotationSpeed;
    public float verticalInput;
    public InputController inputController;
    // Start is called before the first frame update

    bool forwardPressed;
    bool rightPressed;
    bool leftPressed;
    bool backwardPressed;
    bool runPressed;



    private void Awake()
    {
        inputController = new InputController();
        inputController.CharacterInput.UpButton.performed += ctx => forwardPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.DownButton.performed += ctx => backwardPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.RightButton.performed += ctx => rightPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.LeftButton.performed += ctx => leftPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.RunButton.performed += ctx => runPressed = ctx.ReadValueAsButton();


        inputController.CharacterInput.UpButton.performed += ctx => Debug.Log("Pressing UP!");
    }

    private void OnEnable()
    {
        inputController.CharacterInput.Enable();
    }

    private void OnDisable()
    {
        inputController.CharacterInput.Disable();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float tiltDirection = 0;

        tiltDirection = forwardPressed ? 1 : tiltDirection;
        tiltDirection = backwardPressed ? -1 : tiltDirection;




        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (forwardPressed || backwardPressed)
        {

            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.right * tiltDirection *  rotationSpeed * Time.deltaTime);
        }
    }
}
