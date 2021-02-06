using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAgainstPlayer : MonoBehaviour
{

    private GameObject player;
    private Rigidbody myRb;
    public float speed = 10;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        myRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 distance = player.transform.position - transform.position;

        myRb.AddForce(distance.normalized * speed * Time.deltaTime);
    }
}
