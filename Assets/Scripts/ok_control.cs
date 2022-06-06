using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok_control : MonoBehaviour
{
    //float vertical, horizantal;
    public float speed;
    public Joystick joystick;
    Vector2 shoot;
    //public Transform shoot;
    public Rigidbody2D rb;
    //public Transform shootingarrow;
    public GameObject Arrow;
    public float arrowSpeed;


    void Update()
    {
        shoot.x = joystick.Horizontal;
        shoot.y = joystick.Vertical;
        float xaxis = joystick.Horizontal;
        float yaxis = joystick.Vertical;
        float zaxis = Mathf.Atan2(xaxis, yaxis) * Mathf.Rad2Deg;
        transform.eulerAngles = new Vector3(0, 0, -zaxis);
        if (Input.GetMouseButtonDown(1) && Input.mousePosition.x >= Screen.width / 2)
        {
            Shoot();
        }



    }
    private void FixedUpdate()
    {

        //rb    .MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }


    void Shoot()
    {
        GameObject ArrowIns = Instantiate(Arrow, transform.position, Quaternion.identity);
        ArrowIns.GetComponent<Rigidbody2D>().velocity = new Vector2(5.0f, 0.0f);
        //arrowrb.AddForce(shootingarrow.up * arrowSpeed * Time.deltaTime, ForceMode2D.Impulse);
    }
}
