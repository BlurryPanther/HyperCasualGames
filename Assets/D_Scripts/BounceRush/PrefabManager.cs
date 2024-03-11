using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager : MonoBehaviour
{
    public GameObject[] platforms;

    public GameObject GetRandomPrefab()
    {
        int randomIndex = Random.Range(0, platforms.Length);

        return platforms[randomIndex];
    }
}
