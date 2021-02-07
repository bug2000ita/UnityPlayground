using System.Collections;
using System.Collections.Generic;
using UnityEditor.iOS.Xcode;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerControllerX4 : MonoBehaviour
{
    private Rigidbody playerRb;
    private float speed = 500;
    private float boostSpeed = 800;
    private GameObject focalPoint;

    public bool hasPowerup;
    public GameObject powerupIndicator;
    public int powerUpDuration = 5;

    private float normalStrength = 10; // how hard to hit enemy without powerup
    private float powerupStrength = 30; // how hard to hit enemy with powerup


    private InputController inputController;

    private bool forwardPressed;
    private bool backwardPressed;
    private bool boostPressed;

    private void Awake()
    {
        inputController = new InputController();
        inputController.CharacterInput.UpButton.performed += ctx => forwardPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.DownButton.performed += ctx => backwardPressed = ctx.ReadValueAsButton();
        inputController.CharacterInput.RunButton.performed += ctx => boostPressed = ctx.ReadValueAsButton();
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
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
        powerupIndicator.SetActive(hasPowerup);
    }

    void Update()
    {

        var maxSpeed = boostPressed ? boostSpeed : speed;

        // Add force to player in direction of the focal point (and camera)
        if (forwardPressed)
        {
            playerRb.AddForce(focalPoint.transform.forward * maxSpeed * Time.deltaTime);
        }
        else if (backwardPressed)
        {
            playerRb.AddForce(-focalPoint.transform.forward * maxSpeed * Time.deltaTime);
        }

        if(boostPressed)
        {
            powerupIndicator.SetActive(true);

        }
        else
        {
            if (!hasPowerup)
            {
                powerupIndicator.SetActive(false);
            }
        }

        // Set powerup indicator position to beneath player
        if (hasPowerup)
        {
            powerupIndicator.transform.Rotate(Vector3.up, Time.deltaTime * 500);
        }

        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.6f, 0);
        

    }

    // If Player collides with powerup, activate powerup
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
            hasPowerup = true;
            powerupIndicator.SetActive(hasPowerup);
            StartCoroutine(PowerupCooldown());

        }
    }

    // Coroutine to count down powerup duration
    IEnumerator PowerupCooldown()
    {
        yield return new WaitForSeconds(powerUpDuration);
        hasPowerup = false;
        powerupIndicator.SetActive(hasPowerup);
    }

    // If Player collides with enemy
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyRigidbody = other.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer =   (other.gameObject.transform.position - transform.position).normalized;

            if (hasPowerup) // if have powerup hit enemy with powerup force
            {
                enemyRigidbody.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
            }
            else // if no powerup, hit enemy with normal strength 
            {
                enemyRigidbody.AddForce(awayFromPlayer * normalStrength, ForceMode.Impulse);
            }


        }
    }



}
