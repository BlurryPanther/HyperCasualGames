using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose1 : MonoBehaviour
{
    public GameObject UI;

    private void Start()
    {
        Time.timeScale = 1f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.CompareTag("Box"))
        {
            Time.timeScale = 0f;
            UI.SetActive(true);
        }

    }
}
