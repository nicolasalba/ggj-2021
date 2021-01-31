using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigoPapa : MonoBehaviour
{
    public float vel = -1f;
    [SerializeField]float velY = -1f;
    Rigidbody2D rgb;


    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 v = new Vector2(vel, velY);
        rgb.velocity = v;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Wall"))
        {
            Flip();
        }
        else if(other.gameObject.CompareTag("Mob"))
        {
            Physics2D.IgnoreCollision(other, GetComponent<Collider2D>());
        }
    }

    void Flip()
    {
        vel *= -1;
        var s = transform.localScale;
        s.x *= -1;
        transform.localScale = s;
    }
}
