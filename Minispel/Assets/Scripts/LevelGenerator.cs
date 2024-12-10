using UnityEngine;
using System.Collections.Generic;

public class EndlessObstacleGenerator : MonoBehaviour
{
    public GameObject[] tilePrefabs;
    public Transform player;
    private float tileLength = 17f;
    private float spawnDistance = 15f;
    private float lastSpawnX;
    private Queue<GameObject> activeTiles;

    public void Start()
    {
        lastSpawnX = player.position.x;
        activeTiles = new Queue<GameObject>();
        SpawnInitialTiles();
    }

    public void Update()
    {
        //Kollar om spelaren har rört sig tillräckligt långt för att spawna en ny tile
        if (player.position.x + spawnDistance > lastSpawnX)
        {
            SpawnTile();
        }

        DestroyOldTiles();
    }

    void SpawnTile()
    {
        if (tilePrefabs.Length == 0)
        {
            return;
        }

        //Väljer en slumpmässig tile från "tilePrefabs" arrayn
        GameObject tile = tilePrefabs[Random.Range(0, tilePrefabs.Length)];

        //Beräknar spawn positionen för nya tilen
        Vector3 spawnPosition = new(lastSpawnX + tileLength, 0, 0);
        GameObject newTile = Instantiate(tile, spawnPosition, Quaternion.identity);

        newTile.tag = "Tile";
        activeTiles.Enqueue(newTile);

        lastSpawnX = spawnPosition.x;
    }

    void SpawnInitialTiles()
    {
        for (int i = 0; i < 5; i++)
        {
            SpawnTile();
        }
    }

    //Tar bort tiles som är bakom spelaren
    void DestroyOldTiles()
    {
        while (activeTiles.Count > 0)
        {
            GameObject tile = activeTiles.Peek();

            //Om tilen bakom spelaren är langre bak än "spawnDistance" ta bort den
            if (tile.transform.position.x < player.position.x - spawnDistance)
            {
                activeTiles.Dequeue();
                Destroy(tile);
            }
            else
            {
                break;
            }
        }
    }
}
