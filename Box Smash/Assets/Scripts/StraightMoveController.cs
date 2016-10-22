using UnityEngine;
using System.Collections;
using System;

public class StraightMoveController : Controller {

    void Start() {
        setSpeed(5);
    }

    public override void Move()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1 * speed);
    }

    
    public override void setSpeed(float speed){
        this.speed = speed;
    }

   

    
   

    
}
