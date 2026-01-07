using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    public Animator animator;
    private Rigidbody2D rb;
    [SerializeField] GameObject FireBallPrefab;
    [SerializeField] private float jumpForce = 3f;
    [SerializeField] private float speed = 2f;
    private bool isGround;
    private bool faceRight;
    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        isGround = false;
        faceRight = true;
    }
    private void Update()
    {
        Jump();
        Die();
        Crouch();
        Walk();
        Attack();
        Strike();
    }
    public void Facing()
    {
        if(faceRight)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
    public void Walk()
    {
        Facing();
        if(Input.GetKey(KeyCode.D))
        {
            faceRight = true;
            rb.AddForce(Vector3.right * speed, ForceMode2D.Force);
            animator.SetBool("Walk", true);
        }else if (Input.GetKey(KeyCode.A))
        {
            faceRight = false;
            rb.AddForce(Vector3.left * speed, ForceMode2D.Force);
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }
    public void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode2D.Impulse);
            animator.SetTrigger("Jump");
            isGround = false;
        }
    }
    public void Die()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            animator.SetTrigger("Die");
            Destroy(gameObject, 1f);
        }
    }
    public void Crouch()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("Crouch", true);
        }
        else{
            animator.SetBool("Crouch", false);
        }
    }
    public void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
        }
    }
    public void Strike()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("Strike");
        }
    }
}
