using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public InputHandler inputHandler;
    public Animator animator;
    public PlayerMovement playerMovement;
    public PlayerHealth playerHealth;
    private void Awake()
    {
        inputHandler = GetComponent<InputHandler>();
        animator = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
        playerHealth = GetComponent<PlayerHealth>();
    }
    private void Update()
    {
        Walk();
        Jump();
        Attack();
        Strike();
    }
    public void Walk()
    {
        if ((Mathf.Abs(inputHandler.moveX) >=0.1f))
        {
            animator.SetFloat("Walk", 0.2f);
        }
        else
        {
            animator.SetFloat("Walk", 0);
        }
    }
    public void Jump()
    {
        if (inputHandler.jumpPressed && playerMovement.isGround) animator.SetTrigger("Jump");

    }
    public void Strike()
    {
        if (inputHandler.strikePressed) animator.SetTrigger("Strike");
    }
    public void Attack()
    {
        if (inputHandler.attackPressed) animator.SetTrigger("Attack");
    }
    public void Die()
    {
        if(playerHealth.currentHealth<=0) animator.SetTrigger("Die");
    }
    public void Win()
    {
        animator.SetTrigger("Win");
    }
    public void Dizzy()
    {
        animator.SetTrigger("Dizzy");
    }
    public void Hurt()
    {
        animator.SetTrigger("Hurt");
    }

}
