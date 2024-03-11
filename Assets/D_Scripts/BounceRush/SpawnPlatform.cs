using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject spawnPointG1;
    public GameObject spawnPointG2;
    public PrefabManager prefabManagerG1;
    public PrefabManager prefabManagerG2;
    public float spawnInterval = 2f;
    public float yOffset = 1f;
    private float timer;
    private bool spawnFromG1 = true;
    private Vector3 currentSpawnPositionG1;
    private Vector3 currentSpawnPositionG2;

    private void Start()
    {
        timer = spawnInterval;
        currentSpawnPositionG1 = spawnPointG1.transform.position; // Inicializar la posición de G1
        currentSpawnPositionG2 = spawnPointG2.transform.position; // Inicializar la posición de G2
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            spawner();
        }
    }

    private void spawner()
    {
        GameObject randomPrefab;
        Vector3 currentSpawnPosition;

        if (spawnFromG1)
        {
            randomPrefab = prefabManagerG1.GetRandomPrefab();
            currentSpawnPosition = currentSpawnPositionG1;
        }
        else
        {
            randomPrefab = prefabManagerG2.GetRandomPrefab();
            currentSpawnPosition = currentSpawnPositionG2;
        }

        GameObject newPlatform = Instantiate(randomPrefab, currentSpawnPosition, Quaternion.identity);
        Destroy(newPlatform, 15f);

        // Actualizar la posición de G1 y G2
        currentSpawnPositionG1.y += yOffset;
        currentSpawnPositionG2.y += yOffset;

        // Alternar entre G1 y G2 para la próxima iteración
        spawnFromG1 = !spawnFromG1;

        timer = spawnInterval;
    }
}

