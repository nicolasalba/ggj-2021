using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    GameObject player = default;


    void Update()
    {
        if (player)
        {
            float posX = player.transform.position.x + 4f;
            transform.position = new Vector3(posX, transform.position.y, transform.position.z);
        }
    }
}
