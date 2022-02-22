using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float horizontalInput;
    public float verticalInput;   
    private float speed = 5;
    void Start()
    {
    }

    void Update()
    {
        Movement();
       
    }
    public void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * speed * Time.deltaTime * verticalInput);

        if (transform.position.x < -8.9)
        {
            transform.position = new Vector3(-8.9f, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 8.9)
        {
            transform.position = new Vector3(8.9f, transform.position.y, transform.position.z);
        }

        if (transform.position.y < -2.5)
        {
            transform.position = new Vector3(transform.position.x, -2.5f, transform.position.z);
        }

        if (transform.position.y > 6)
        {
            transform.position = new Vector3(transform.position.x, 6, transform.position.z);
        }
    }


  
}
