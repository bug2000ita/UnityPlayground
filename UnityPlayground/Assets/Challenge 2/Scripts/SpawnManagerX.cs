using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private List<GameObject> createdObjects;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        createdObjects = new List<GameObject>();
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    private void Update()
    {
        foreach(var item in createdObjects)
        {
            if(item!=null && item.transform.position.y<0)
            {
                createdObjects.Remove(item);
                Destroy(item);
                break;
                
            }
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int valueIndex = Random.Range(0, 3);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        var ball = Instantiate(ballPrefabs[valueIndex], spawnPos, ballPrefabs[valueIndex].transform.rotation);

        createdObjects.Add(ball);
    }

}
