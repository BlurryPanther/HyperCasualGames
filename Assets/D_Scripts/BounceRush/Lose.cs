using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    public Scene_Manager scene_Manager;
    [SerializeField]private float TimeToWait = 1;
    public GameObject Spawner;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("LoseTrigger"))
        {
            StartCoroutine(RestartTime());
            Destroy(Spawner);
        }
    }

    IEnumerator RestartTime()
    {
        yield return new WaitForSeconds(TimeToWait);

        scene_Manager.Restart();
    }
}
