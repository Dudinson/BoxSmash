using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

  
    

    public GameObject GetHitedObject()
    {
        if (Input.GetMouseButtonDown(0))
        {

           RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                return hit.collider.gameObject;
            }

        }

        return null;
       
    }

   






}
