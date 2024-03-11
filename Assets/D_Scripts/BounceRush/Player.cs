using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D player;
    public float jumpForce;
    public bool isGrounded;

    private void Update()
    {
        
        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            Jump();
        }
    }
    #region JumpLogic
    private void Jump()
    {
        player.velocity = Vector2.up * jumpForce;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Box"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Box"))
        {
            isGrounded = false;
        }
    }
    #endregion
}
