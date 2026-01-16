using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class PlayerMovement : MonoBehaviour
{
    public InputHandler inputHandler;
    public float speed;
    public float jumpForce;
    public Rigidbody2D rb;
    public bool isGround;
    private void Awake()
    {
        inputHandler = GetComponent<InputHandler>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Flip();
        Move();
        Jump();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }else isGround = false;
    }
    public void Flip()
    {
        if (inputHandler.rightKeyPressed)
        {
            transform.localScale = Vector3.one;
        }
        else if (inputHandler.leftKeyPressed)
        {
            transform.localScale = new Vector3(-1,1,1);
        }
    }
    public void Move()
    {
        rb.velocity = new Vector2(inputHandler.moveX, rb.velocity.y);
    }
    public void Jump()
    {
        if (inputHandler.jumpPressed)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    
}
