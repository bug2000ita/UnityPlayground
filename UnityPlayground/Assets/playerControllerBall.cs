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

    public bool IsPowerUpEnable;
    public float PowerUpStrenght = 50;

    public GameObject powerUpIndicator;

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
        powerUpIndicator.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        powerUpIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
        powerUpIndicator.transform.Rotate(Vector3.up, Time.deltaTime * 180);

        if (forwardPressed)
        {
            playerRb.AddForce(focalPoint.transform.forward * SpeedMovement * Time.deltaTime);
        }
        if(backwardPressed)
        {
            playerRb.AddForce(-focalPoint.transform.forward * SpeedMovement * Time.deltaTime);
        }

        powerUpIndicator.SetActive(IsPowerUpEnable);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PowerUp"))
        {
            Destroy(other.gameObject);
            IsPowerUpEnable = true;
            StartCoroutine(PowerUpTime());
        }
    }

    private IEnumerator PowerUpTime()
    {
        yield return new WaitForSeconds(5);
        IsPowerUpEnable = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && IsPowerUpEnable)
        {
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = collision.gameObject.transform.position - transform.position;
            enemyRb.AddForce(PowerUpStrenght * awayFromPlayer, ForceMode.Impulse);
            
        }
    }

}
