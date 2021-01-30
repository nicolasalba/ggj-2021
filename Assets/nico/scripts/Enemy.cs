using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MovableEntity
{
    [SerializeField] Player playerToFollow;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 distance = playerToFollow.transform.position - gameObject.transform.position;
        moveHorizontal(distance.x);
    }
}
