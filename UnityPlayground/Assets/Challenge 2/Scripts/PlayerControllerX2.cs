using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX2 : MonoBehaviour
{
    public GameObject dogPrefab;

    private GameObject runningDog;

    bool forwardPressed;
    bool rightPressed;
    bool leftPressed;
    bool backwardPressed;
    bool runPressed;

    private float spawnLimitXLeft = -22;

    private InputController inputController;

    private void Start()
    {

    }

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


    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (forwardPressed && runningDog==null)
        {
            runningDog = Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }

        if (runningDog != null && runningDog.transform.position.x<spawnLimitXLeft)
        {
            Destroy(runningDog);
        }
    }
}
