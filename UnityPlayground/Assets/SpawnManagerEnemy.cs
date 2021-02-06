using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerEnemy : MonoBehaviour
{

    public GameObject EnemyPreFab;
    private float spawnRange = 9;
    // Start is called before the first frame update
    void Start()
    {
        float randomValueX = Random.Range(-spawnRange, spawnRange);
        float randomValueZ = Random.Range(-spawnRange, spawnRange);
        Vector3 vectorSpawn = new Vector3(randomValueX, 0, randomValueZ);
        Instantiate(EnemyPreFab, vectorSpawn, EnemyPreFab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
