using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float spawnRate = 3f;
    public float minHeight = -1f;
    public float maxHeight = 3f;
    private float lastSpawnTime;
    public GameObject[] Prefabs;

    private void Update()
    {
        GenerateObstacles();
    }

    private void GenerateObstacles()
    {
        if (Time.time - lastSpawnTime > spawnRate)
        {
            GameObject selectedPrefab = Prefabs[Random.Range(0, Prefabs.Length)];

            float randomHeight = Random.Range(minHeight, maxHeight);

            Vector3 spawnPosition = new Vector3(transform.position.x, randomHeight, 0);
            Instantiate(selectedPrefab, spawnPosition, Quaternion.identity);

            lastSpawnTime = Time.time;
        }
    }
}
