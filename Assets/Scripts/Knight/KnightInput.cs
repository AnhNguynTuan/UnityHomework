using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightInput : InputHandler
{
    public KeyCode BlockKey;
    public KeyCode DashKey;
    public KeyCode CastKey;
    public bool isBlock;
    public bool isDash;
    public bool isCast;

    public override void ReadActions()
    {
        base.ReadActions();
        if(Input.GetKey(BlockKey)) isBlock = true;
        if(Input.GetKey(DashKey)) isDash = true;
        if( Input.GetKey(CastKey)) isCast = true;   
    }
}
