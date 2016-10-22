using UnityEngine;
using System.Collections;
using System;

public class DiagonalMoveController : Controller
{
    private float horizontalSpeed = 5;

    void Start(){
        setSpeed(4);
        setHorizontalSpeed(-5);
    }


    public override void Move(){
        GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalSpeed, -1 * speed);
    }


    public override void setSpeed(float speed)
    {
        this.speed = speed;
    }


    void setHorizontalSpeed(float horizontalSpeed) {
        this.horizontalSpeed = horizontalSpeed;
    }


    void OnCollisionEnter2D(Collision2D col)
    {

        

        if (col.gameObject.tag == "RightBorder") {
            setHorizontalSpeed(-5);
        }

        if (col.gameObject.tag == "LeftBorder")
        {
            setHorizontalSpeed(5);
        }

    }
}
