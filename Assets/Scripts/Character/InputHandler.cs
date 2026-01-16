using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class InputHandler : MonoBehaviour
{
    public float moveX;
    public KeyCode LeftKey;
    public KeyCode RightKey;
    public KeyCode JumpKey;
    public KeyCode StrikeKey;
    public KeyCode AttackKey;
    public bool jumpPressed;
    public bool strikePressed;
    public bool leftKeyPressed;
    public bool rightKeyPressed;
    public bool attackPressed;

    private void Update()
    {
        ReadActions();
        ReadMovement();
    }
    public virtual void ReadActions()
    {
        leftKeyPressed = Input.GetKey(LeftKey);
        rightKeyPressed = Input.GetKey(RightKey);
        jumpPressed = Input.GetKeyDown(JumpKey);
        strikePressed = Input.GetKeyDown(StrikeKey);
        attackPressed = Input.GetKeyDown(AttackKey);
    }
    public void ReadMovement()
    {
        if (leftKeyPressed) moveX = -1f;
        else if (rightKeyPressed) moveX = 1f;
        else moveX = 0f;
    }
}
