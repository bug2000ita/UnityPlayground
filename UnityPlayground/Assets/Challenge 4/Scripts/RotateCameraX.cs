using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCameraX : MonoBehaviour
{
    private float speed = 200;
    public GameObject player;


    private InputController inputController;

    private bool leftPressed;
    private bool rightPressed;

    private void Awake()
    {
        inputController = new InputController();
        inputController.CharacterInput.LeftButton.performed += ctx => leftPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.RightButton.performed += ctx => rightPressed = ctx.ReadValueAsButton();
    }

    private void OnEnable()
    {
        inputController.CharacterInput.Enable();
    }

    private void OnDisable()
    {
        inputController.CharacterInput.Disable();
    }

    // Update is called once per frame
    void Update()
    {
        if (rightPressed)
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
        else if(leftPressed)
        {
            transform.Rotate(-Vector3.up, speed * Time.deltaTime);
        }

        transform.position = player.transform.position; // Move focal point with player

    }
}
