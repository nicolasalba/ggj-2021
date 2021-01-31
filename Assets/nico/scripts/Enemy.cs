using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MovableEntity
{
    [SerializeField] Player playerToFollow;
    [SerializeField] float distanceToFollow;
    bool follow = false;

    new void Start()
    {
        
    }

    void Update()
    {
        Vector2 distance = playerToFollow.transform.position - gameObject.transform.position;
        if (!follow && distance.magnitude <= distanceToFollow)
        {
            follow = true;
        }
        if (follow)
        {
            MoveHorizontal(distance.x);
        }
    }
}
