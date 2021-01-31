using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MovableEntity
{
    Animator anim;
    [SerializeField] float jumpSpeed = 400;
    Rigidbody2D body;
    bool canJump = true;
    AudioSource audioData;


    public override void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioData = GetComponent<AudioSource>();
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

    public void Jump(bool jumpPressed)
    {

        if (jumpPressed && canJump)
        {
            body.AddForce(Vector2.up * jumpSpeed);
            canJump = false;
            audioData.Play(0);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("Wall");
    }
}
