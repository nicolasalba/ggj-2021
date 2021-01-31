using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PoisonsController : MonoBehaviour
{
    public int poisonCount;

    [SerializeField]
    Text poisonTxt = default;

    void Start() 
    {
        poisonCount = 0;
        poisonTxt.text = "x0";
    }

    private void OnCollisionEnter2D(Collision2D other) {
        switch(other.gameObject.tag) {
            case "Poison":
                Destroy(other.gameObject);
                poisonCount++;
                poisonTxt.text = $"x{poisonCount}";
                break;

            case "Mob":
                Destroy(gameObject);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                break;

            default:
                break;
        }
    }

}
