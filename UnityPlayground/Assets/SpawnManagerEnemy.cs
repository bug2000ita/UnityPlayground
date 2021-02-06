using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerEnemy : MonoBehaviour
{

    public GameObject enemyPreFab;
    public GameObject powerUpFab;
    private float spawnRange = 9;

    private int waveCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        CreateInstance(enemyPreFab);
    }

    // Update is called once per frame
    void Update()
    {

        FindLoserAndDestroy();
        int enemyCount = FindObjectsOfType<FollowAgainstPlayer>().Length;

        if(enemyCount==0)
        {
            waveCount++;
            SpawnWave(waveCount);

        }
    }

    private void FindLoserAndDestroy()
    {
        FollowAgainstPlayer[] enemies = FindObjectsOfType<FollowAgainstPlayer>();
        foreach (var enemy in enemies)
        {
            if (enemy.gameObject != null && enemy.gameObject.transform.position.y<-10)
            {
                Destroy(enemy.gameObject);
            }
        }
    }

    void SpawnWave(int number)
    {
        for (int i = 0; i < number; i++)
        {
            CreateInstance(enemyPreFab);
            CreateInstance(powerUpFab);
        }
    }

    void CreateInstance(GameObject preFab)
    {
        float randomValueX = Random.Range(-spawnRange, spawnRange);
        float randomValueZ = Random.Range(-spawnRange, spawnRange);
        Vector3 vectorSpawn = new Vector3(randomValueX, 0, randomValueZ);
        Instantiate(preFab, vectorSpawn, preFab.transform.rotation);
    }
}
