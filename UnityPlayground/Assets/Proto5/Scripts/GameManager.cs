using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] items;
    private float delay = 1;
    private float repeatSpawn = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnTargets());
        //InvokeRepeating("SpawnTarget", delay, repeat);
    }

    IEnumerator SpawnTargets()
    {
        while (true)
        {
            yield return new WaitForSeconds(repeatSpawn);
            SpawnTarget();
        }
            
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTarget()
    {
        int randomIndex = Random.Range(0, 4);
        Instantiate(items[randomIndex]);
    }
}
