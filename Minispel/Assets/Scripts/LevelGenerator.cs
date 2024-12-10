using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject[] platformPrefabs;
    public float spawnDistance = 10f;
    public Transform player;
    private float lastSpawnX;

    void Start()
    {
        lastSpawnX = player.position.x;
        SpawnInitialPlatforms();
    }

    void Update()
    {
        if (player.position.x + spawnDistance > lastSpawnX)
        {
            SpawnPlatform();
        }
    }

    void SpawnPlatform()
    {
        GameObject platform = platformPrefabs[Random.Range(0, platformPrefabs.Length)];

        Vector3 spawnPosition = new Vector3(lastSpawnX + platform.GetComponent<Renderer>().bounds.size.x, Random.Range(-2f, 2f), 0);
        Instantiate(platform, spawnPosition, Quaternion.identity);

        lastSpawnX = spawnPosition.x;
    }

    void SpawnInitialPlatforms()
    {
        for (int i = 0; i < 5; i++)
        {
            SpawnPlatform();
        }
    }
}

