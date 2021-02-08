using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    public int pointValue = 5;
    public ParticleSystem explosionParticle;
    private Rigidbody objectRB;

    private float maxSpeed = 14f;
    private float minspeed = 10f;
    private float maxTorch = 10f;
    private float xMaxPosition = 4;
    private float yPosition = 0;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        objectRB = GetComponent<Rigidbody>();

        objectRB.AddForce(RandomForce(), ForceMode.Impulse);
        objectRB.AddTorque(RandomTorch(),ForceMode.Impulse);

        transform.position = RandomSpawnPos();

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (!gameManager.isGameOver)
        {
            Destroy(gameObject);
            gameManager.UpdateScore(pointValue);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);

            if (gameObject.CompareTag("Bad"))
            {
                gameManager.GameOver();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        gameManager.GameOver();
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minspeed, maxSpeed);
    }

    Vector3 RandomTorch()
    {
        return new Vector3(Random.Range(-maxTorch, maxTorch), Random.Range(-maxTorch, maxTorch), Random.Range(-maxTorch, maxTorch));
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xMaxPosition, xMaxPosition), -yPosition,0);
    }
}
