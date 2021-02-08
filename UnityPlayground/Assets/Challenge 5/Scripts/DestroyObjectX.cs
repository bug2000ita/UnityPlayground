using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(gameObject); 
    }


}
