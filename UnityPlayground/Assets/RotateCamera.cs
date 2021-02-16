using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float RotationSpeed = 100f;

    private InputController inputController;
    private bool rightPressed;
    private bool leftPressed;


    private void Awake()
    {
        inputController = new InputController();
        inputController.CharacterInput.RightButton.performed += ctx => rightPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.LeftButton.performed += ctx => leftPressed = ctx.ReadValueAsButton();
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
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (leftPressed)
        //{
        //    transform.Rotate(Vector3.up, 0* RotationSpeed * Time.deltaTime);

        //}
        //else if (rightPressed)
        //{
        //    transform.Rotate(Vector3.up, -RotationSpeed * 0 *Time.deltaTime);
        //}

    }
}
