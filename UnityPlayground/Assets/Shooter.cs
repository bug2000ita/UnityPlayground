using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    InputController inputController;
    bool shootPressed;
    bool leftPressed;
    bool righPressed;
    bool upPressed;
    bool downPressed;
    public GameObject bulletBall;
    public GameObject shooterDirection;

    private bool enableShoot;

    Rigidbody objectRB;

    // Start is called before the first frame update
    void Start()
    {
        objectRB = GetComponent<Rigidbody>();

        inputController.CharacterInput.JumpButton.performed += ctx => shootPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.LeftButton.performed += ctx => leftPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.RightButton.performed += ctx => righPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.UpButton.performed += ctx => upPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.DownButton.performed += ctx => downPressed = ctx.ReadValueAsButton();

        StartCoroutine(EnableShoot()); 
    }

    private IEnumerator EnableShoot()
    {
        while (true)
        {
            yield return new WaitForSeconds(2);
            enableShoot = true;
        }
    }

    private void Awake()
    {
        inputController = new InputController();
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

        float angleX = transform.eulerAngles.x;
        float angleY = transform.eulerAngles.y;
        float angleZ = transform.eulerAngles.z;
        var cameraTransform = GameObject.Find("Main Camera").transform;

        if (leftPressed)
        {
            objectRB.transform.Rotate(Vector3.left, Time.deltaTime * 18);
            cameraTransform.Rotate(Vector3.down, Time.deltaTime * 10);
        }


        if (righPressed )
        {
            objectRB.transform.Rotate(Vector3.right, Time.deltaTime * 18);
            cameraTransform.Rotate(Vector3.up, Time.deltaTime * 10);
        }

        if(upPressed)
        {
            objectRB.transform.Rotate(Vector3.forward, Time.deltaTime * 18);
            cameraTransform.Rotate(Vector3.right, Time.deltaTime * 10);
        }

        if (downPressed)
        {
            objectRB.transform.Rotate(Vector3.forward, -Time.deltaTime * 18);
            cameraTransform.Rotate(Vector3.left, Time.deltaTime * 10);
        }

        if(shootPressed && enableShoot)
        {
            Vector3 direction = (GameObject.Find("ShooterPart3").transform.position - GameObject.Find("ShooterPart4").transform.position);
            enableShoot = false;

            Instantiate(bulletBall, GameObject.Find("Target").transform.position, objectRB.transform.rotation).GetComponent<Rigidbody>().AddForce(direction * 50, ForceMode.Impulse);
        }
    }

}
