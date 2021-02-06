using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public float speedRotation = 1000;

    // Initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * speedRotation);
    }
}
