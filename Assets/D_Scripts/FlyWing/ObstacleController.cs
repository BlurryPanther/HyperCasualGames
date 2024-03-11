using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public float speed = -1.5f;
    public float timeOffset = 5f;

    private void Update()
    {
        MoveObstacle();

    }

    private void MoveObstacle()
    {

        transform.position += new Vector3(speed, 0, 0) * Time.deltaTime;
        StartCoroutine("destroyObj");
    }

    IEnumerator destroyObj()
    {
        yield return new WaitForSeconds(timeOffset);

        Destroy(gameObject);
    }
}
