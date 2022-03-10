using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    
    
    

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval;

    void Start()
    {
        spawnInterval = Random.Range(3f, 5f);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    
    void SpawnRandomBall ()
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int number = Random.Range(0, 3);
        Instantiate(ballPrefabs[number], spawnPos, ballPrefabs[number].transform.rotation);

    }

}
