using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableEntity : MonoBehaviour
{
    [SerializeField] float speed = 1;
   

    public virtual void Start()
    {
       
    }

    

    public virtual void MoveHorizontal(float horizontal)
    {
        Vector2 scale = gameObject.transform.localScale;
        if (horizontal < 0)
        {
            gameObject.transform.localScale = new Vector2(-0.7f, 0.7f);
        }
        else if (horizontal > 0)
        {
            gameObject.transform.localScale = new Vector2(0.7f, 0.7f);
        }
        gameObject.transform.Translate(new Vector2(horizontal, 0) * speed * Time.deltaTime);
    }

   

}
