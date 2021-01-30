using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MovableEntity
{
    Animator anim;

    public override void Start()
    {
        base.Start();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        bool jumpPressed = Input.GetKeyDown(KeyCode.Space);
        MoveHorizontal(horizontal);
        Jump(jumpPressed);
    }

    public override void MoveHorizontal(float horizontal)
    {
        base.MoveHorizontal(horizontal);
        anim.SetBool("Walking", horizontal > 0.01 || horizontal < -0.01);
    }
}
