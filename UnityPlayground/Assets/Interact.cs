using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    float multiplier = -1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        var rotation = multiplier * Time.deltaTime * 45;

        transform.Rotate(Vector3.up, rotation);
    }
}
