using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    Rigidbody objectRb;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(-0.28f,1.8f,0)* 100, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
