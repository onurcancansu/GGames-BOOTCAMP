using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow_movement : MonoBehaviour
{
    //public Vector2 direction;
    public GameObject arrowprefab;
    //public Joystick joystick;
    public Transform shootpoint;
    public float LaunchForce;
    void Update()
    {
        Vector2 bowposition = transform.position;
        Vector2 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mouseposition - bowposition;
        transform.right = direction;
        
        //MeetMouse();*/
        
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
   //&& Input.mousePosition.x >= Screen.width / 2
    
    void Shoot()
    {
        GameObject newarrow = Instantiate(arrowprefab, shootpoint.position, shootpoint.rotation);
        newarrow.GetComponent<Rigidbody2D>().velocity = transform.right * LaunchForce;
    }
}
