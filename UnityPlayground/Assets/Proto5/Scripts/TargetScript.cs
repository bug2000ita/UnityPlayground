using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    private Rigidbody objectRB;

    private float maxSpeed = 14f;
    private float minspeed = 10f;
    private float maxTorch = 10f;
    private float xMaxPosition = 4;
    private float yPosition = 0;

    // Start is called before the first frame update
    void Start()
    {
        objectRB = GetComponent<Rigidbody>();

        objectRB.AddForce(RandomForce(), ForceMode.Impulse);
        objectRB.AddTorque(RandomTorch(),ForceMode.Impulse);

        transform.position = RandomSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y<-10)
        {
            Destroy(gameObject);
        }
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
