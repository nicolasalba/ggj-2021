using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoisonsController : MonoBehaviour
{
    public int poisonCount;

    [SerializeField]
    Text poisonTxt = default;

    void Start() 
    {
        poisonCount = 0;
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.transform.CompareTag("Poison")) {
            poisonCount++;
            poisonTxt = $"x{poisonCount}";
            Destroy(other.gameObject);
        }
    }
}
