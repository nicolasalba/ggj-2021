using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] float jumpSpeed = 400;
    Rigidbody2D playerBody;
    bool canJump = true;

    void Start()
    {
        playerBody = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        doMove();
    } 

    private void doMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        bool jumpPressed = Input.GetKeyDown(KeyCode.Space);
        moveHorizontal(horizontal);
        if (jumpPressed && canJump)
        {
            playerBody.AddForce(Vector2.up * jumpSpeed);
            canJump = false;
        }
    }

    private void moveHorizontal(float horizontal)
    {
        if (horizontal < 0)
        {
            gameObject.transform.localScale = new Vector2(-1, 1);
        } else if(horizontal > 0)
        {
            gameObject.transform.localScale = new Vector2(1, 1);
        } 
        gameObject.transform.Translate(new Vector2(horizontal, 0) * speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = collision.transform.tag.Equals("ground");
    }
}
