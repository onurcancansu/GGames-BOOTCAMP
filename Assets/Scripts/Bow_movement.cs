using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow_movement : MonoBehaviour
{
    public Vector2 direction;
   

    // Update is called once per frame
    void Update()
    {
        Vector2 MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 BowPos = transform.position;
        direction = MousePos - BowPos;
        Face();

        
    }
    void Face()
    {
        transform.right = direction;
    }
}
