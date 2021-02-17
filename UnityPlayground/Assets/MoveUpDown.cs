using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour
{

    private float counter = 0;
    public bool isPositive = true;
    // Start is called before the first frame update



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (isPositive)
        {
            counter += 0.01f;
        }
        else
        {
            counter -= 0.01f;
        }

        if(counter>2 || counter <0)
        {
            isPositive = !isPositive;
        }


        if (isPositive)
        {
            transform.position += new Vector3(0, Time.deltaTime * counter, 0);
        }
        else
        {
            transform.position -= new Vector3(0, Time.deltaTime * counter, 0);
        }
    }
}
