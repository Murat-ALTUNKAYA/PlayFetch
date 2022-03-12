using UnityEngine;


public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;
    private float spawnLimitXLeft = -22, spawnLimitXRight = 7, spawnPosY = 30, startDelay = 1.0f, spawnInterval;

    void Start()
    {
        spawnInterval = Random.Range(3f, 5f);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
    void SpawnRandomBall()
    {
        if (Timer.gameContinue)
        {
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

            int number = Random.Range(0, 3);
            Instantiate(ballPrefabs[number], spawnPos, ballPrefabs[number].transform.rotation);
        }
    }

}
