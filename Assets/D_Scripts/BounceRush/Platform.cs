using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private Vector2 forward;
    [SerializeField] private float stopRange = 1f;
    private bool shouldMove = true;
    public Scene_Manager scene_Manager;
    

    private void Update()
    {
        if (shouldMove && Mathf.Abs(transform.position.x) > stopRange)
        {
            transform.Translate(forward * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Player"))
        {
            shouldMove = false;
        }
    }
}
