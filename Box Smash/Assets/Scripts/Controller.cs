using UnityEngine;
using System.Collections;

public abstract class Controller : MonoBehaviour {

    public float speed;

    void Update() {
        Move();
    }

    public void Kill() {
        gameObject.active = false;
    }

    public void Revive() {
        gameObject.active = true;
    }

    public abstract void setSpeed(float speed);

    public  abstract void Move();
}
