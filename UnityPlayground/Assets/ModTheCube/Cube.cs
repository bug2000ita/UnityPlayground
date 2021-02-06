using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float Speed = 5f;
    private Vector3 currentDirection = Vector3.forward;
    private float threasoldZ = 8f;
    private Vector3 prevDirection = Vector3.back;
    private float SpeedRotation = 100f;

    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);

    }

    private void Move()
    {
        if (transform.position.z > threasoldZ)
        {
            currentDirection = Vector3.back;
        }
        else if (transform.position.z < -threasoldZ)
        {
            currentDirection = Vector3.forward;
        }

        transform.Translate(currentDirection * Time.deltaTime * Speed);
    }

    private void Rotate()
    {
        transform.Rotate(currentDirection, Time.deltaTime * SpeedRotation);
        transform.Rotate(Vector3.right, Time.deltaTime * 1);
    }

    private void Scale()
    {
        Vector3 scaleChange = new Vector3(1f, 1f,1f);

        if (transform.position.z > 0)
        {
            transform.localScale += Time.deltaTime * scaleChange;
        }
        else
        {
            transform.localScale -= Time.deltaTime * scaleChange;
        }
    }

    private void Color()
    {
        if (prevDirection != currentDirection)
        {
            var r = UnityEngine.Random.Range(0, 1f);
            var g = UnityEngine.Random.Range(0, 1f);
            var b = UnityEngine.Random.Range(0, 1f);
            var a = UnityEngine.Random.Range(0, 1f);

            Renderer.material.color = new Color(r, g, b, a);

            prevDirection = currentDirection;
        }
    }

    void Update()
    {
        Move();
        Rotate();
        Scale();
        Color();


    }
}
