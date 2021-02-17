using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightLeft : MonoBehaviour
{

    public bool isPositive;
    private float counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = Random.Range(0.8f, 1.2f);
    }

    // Update is called once per frame
    void Update()
    {


        if (counter > 2 || counter < 0)
        {
            isPositive = !isPositive;
        }


        if (isPositive)
        {
            counter += 0.01f;
            transform.position += new Vector3(0, 0, Time.deltaTime * counter);
        }
        else
        {
            counter -= 0.01f;
            transform.position -= new Vector3(0,0, Time.deltaTime * counter);
        }
    }
}
