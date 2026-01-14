using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public int moveX;
    public int facingInput;
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
        ReadFacing();
        ReadMovement();
    }
    public virtual void ReadActions()
    {
        if(Input.GetKey(LeftKey)) leftKeyPressed = true;
        if(Input.GetKey(RightKey)) rightKeyPressed = true;
        if(Input.GetKey(JumpKey)) jumpPressed = true;
        
        if(Input.GetKey(StrikeKey)) strikePressed = true;
        if(Input.GetKey(AttackKey)) attackPressed = true;
    }

    public void ReadFacing()
    {
        if(moveX != 0) facingInput = moveX;
    }
    public void ReadMovement()
    {
        if (leftKeyPressed) moveX = -1;
        else if (rightKeyPressed) moveX = 1;
        else moveX = 0;
    }
}
