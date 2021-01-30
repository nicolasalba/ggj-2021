using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MovableEntity
{

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        bool jumpPressed = Input.GetKeyDown(KeyCode.Space);
        moveHorizontal(horizontal);
        jump(jumpPressed);
    } 
}
