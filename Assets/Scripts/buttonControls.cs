using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class buttonControls : MonoBehaviour
{
    public float jumpForce = 7.0f;
    public float speed = 1.0f;
    private float moveDirection;
    
    
    private bool jump;
    private bool grounded = true;
    private bool moving;
    private Rigidbody2D _rigidbody2D;
    Transform characterTransform;
    public Camera cam;
    Transform camTransform;


    private Animator anim;
    bool hasStopped;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        camTransform = cam.transform;
        characterTransform = this.GetComponent<Transform>();
        
    }

    private void FixedUpdate()
    {
        if (_rigidbody2D.velocity != Vector2.zero)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }

        _rigidbody2D.velocity = new Vector2(speed * moveDirection, _rigidbody2D.velocity.y);

        if (jump == true)
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, jumpForce);
            jump = false;            
        }
    }

    private void Update()
    {
        camTransform.position = new Vector3(characterTransform.position.x+0.5f, characterTransform.position.y+0.5f, camTransform.position.z);
    }


    public void Left()
    {
        
        if (grounded == true)
        {
            moveDirection = -1.0f;
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
                     
            anim.SetFloat("speed", speed);
            hasStopped = false;
        }
        
    }

    public void Right()
    {
        
        if (grounded == true)
        {
            moveDirection = 1.0f;
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
                        
            anim.SetFloat("speed", speed);
            hasStopped = false;
        }
        
    }

    public void Jump()
    {
        if (grounded == true)
        {
            jump = true;
            grounded = false;
            anim.SetTrigger("jump");
            anim.SetBool("grounded", false);
        }
        
    }

    public void Stop()
    {
        
            hasStopped = true;          
        
    }       
   
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Zemin"))
        {
            anim.SetBool("grounded", true);
            grounded = true;
        }
        if (hasStopped)
        {
            moveDirection = 0.0f;
            anim.SetFloat("speed", 0.0f);
            
        }

        
    }

    

}
