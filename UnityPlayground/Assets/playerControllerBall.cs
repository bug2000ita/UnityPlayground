using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControllerBall : MonoBehaviour
{

    private Rigidbody playerRb;
    private InputController inputController;

    private GameObject focalPoint;
    public float SpeedMovement = 100f;
    private bool forwardPressed;
    private bool backwardPressed;

    private void Awake()
    {
        inputController = new InputController();
        inputController.CharacterInput.UpButton.performed += ctx => forwardPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.DownButton.performed += ctx => backwardPressed = ctx.ReadValueAsButton();
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
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        if (forwardPressed)
        {
            playerRb.AddForce(focalPoint.transform.forward * SpeedMovement * Time.deltaTime);
        }
        if(backwardPressed)
        {
            playerRb.AddForce(-focalPoint.transform.forward * SpeedMovement * Time.deltaTime);
        }
        
    }
}
