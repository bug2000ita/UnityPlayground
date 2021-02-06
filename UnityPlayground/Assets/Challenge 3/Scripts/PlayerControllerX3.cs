using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class PlayerControllerX3 : MonoBehaviour
{
    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    bool forwardPressed;

    float upperLimit = 15;
    float bottomLimit = 2;

    private InputController inputController;

    private void Awake()
    {
        inputController = new InputController();
        inputController.CharacterInput.UpButton.performed += ctx => forwardPressed = ctx.ReadValueAsButton();
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
        gameOver = false;
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
        playerRb = GetComponent<Rigidbody>();

        // Apply a small upward force at the start of the game
        playerRb.AddForce(Vector3.up * floatForce, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {

        // While space is pressed and player is low enough, float up
        if (forwardPressed && !gameOver )
        {
            playerRb.AddForce(Vector3.up * floatForce, ForceMode.Impulse);
        }

        if (transform.position.y > upperLimit)
        {
            transform.position = new Vector3(-3, upperLimit, 0);
        }
        if (transform.position.y < bottomLimit)
        {
            transform.position = new Vector3(-3, bottomLimit, 0);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }

    }

}
