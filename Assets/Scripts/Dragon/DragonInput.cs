using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonInput : InputHandler
{
    public KeyCode CrouchKey;
    public KeyCode FlyKickKey;
    public bool crouchPressed;
    public bool flyKickPressed;
    public override void ReadActions()
    {
        base.ReadActions();
        if (Input.GetKey(CrouchKey)) crouchPressed = true;
        if(Input.GetKey(FlyKickKey)) flyKickPressed = true;
    }
}
