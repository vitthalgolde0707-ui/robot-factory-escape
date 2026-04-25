using UnityEngine;
using System.Collections;

public class BatterySpawner : MonoBehaviour
{
    public GameObject batteryPrefab;
    public float spawnDelay = 3f;

    void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);

            SpawnBattery();
        }
    }

    void SpawnBattery()
    {
        if (batteryPrefab == null) return;

        float y = Random.Range(-1f, 2f);
        Vector3 pos = new Vector3(transform.position.x, y, 0);

        Instantiate(batteryPrefab, pos, Quaternion.identity);
    }
}