using UnityEngine;
using System.Collections;

public class GameLevelBorder : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Box") {
            GameManager.lifes--;
        }

        other.gameObject.GetComponent<Controller>().Kill();
    }
}
