using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableEntity : MonoBehaviour
{
    [SerializeField] float speed = 1;
    [SerializeField] float jumpSpeed = 400;
    Rigidbody2D body;
    bool canJump = true;

    public virtual void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }

    public void Jump(bool jumpPressed)
    {
        if (jumpPressed && canJump)
        {
            body.AddForce(Vector2.up * jumpSpeed);
            canJump = false;
        }
    }

    public virtual void MoveHorizontal(float horizontal)
    {
        Vector2 scale = gameObject.transform.localScale;
        if (horizontal < 0)
        {
            gameObject.transform.localScale = new Vector2(-1, 1);
        }
        else if (horizontal > 0)
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
