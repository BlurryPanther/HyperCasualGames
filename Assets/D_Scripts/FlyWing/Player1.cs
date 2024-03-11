using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public Rigidbody2D player;
    public float jumpForce;
    public bool isColliding;
    public Animator Animation;

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && isColliding == false)
        {
            Jump();
        }

        if (Input.GetMouseButtonUp(0))
        {
            Animation.Play("Idle");
        }


    }
    #region JumpLogic
    private void Jump()
    {
        player.velocity = Vector2.up * jumpForce;
        Animation.Play("Up");
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Box"))
        {
            isColliding = true;
            
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Box"))
        {
            isColliding = false;
        }
    }
    #endregion
}
