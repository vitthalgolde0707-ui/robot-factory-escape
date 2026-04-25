using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;

    public float minSpawnTime = 1f;
    public float maxSpawnTime = 3f;

    public float minY = -1f;
    public float maxY = 2f;

    void Start()
    {
        SpawnObstacle();
    }

    void SpawnObstacle()
    {
        float randomY = Random.Range(minY, maxY);

        Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0);

        Instantiate(obstaclePrefab, spawnPos, Quaternion.identity);

        float nextSpawn = Random.Range(minSpawnTime, maxSpawnTime);

        Invoke("SpawnObstacle", nextSpawn);
    }
}