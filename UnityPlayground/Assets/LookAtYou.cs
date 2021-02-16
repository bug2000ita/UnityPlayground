using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtYou : MonoBehaviour
{

    private GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("CenterOfMass");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionTarget = (target.transform.position - transform.position);

        

        transform.LookAt(target.transform.position-new Vector3(0,15,0));
        //transform.Rotate(Vector3.forward, 90);
        transform.Rotate(Vector3.right, 70);


    }
}
