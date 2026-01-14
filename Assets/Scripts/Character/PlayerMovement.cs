using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public InputHandler inputHandler;
    public float speed;
    public Rigidbody2D rb;
    private void Awake()
    {
        inputHandler = GetComponent<InputHandler>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Facing(inputHandler.facingInput);
        Move(inputHandler.moveX);
    }
    public void Facing(int facing)
    {
        transform.localScale = new Vector3(facing, 1, 1);
    }
    public void Move(int moveX)
    {
            rb.velocity = new Vector2(moveX, rb.velocity.y);
    }
}
