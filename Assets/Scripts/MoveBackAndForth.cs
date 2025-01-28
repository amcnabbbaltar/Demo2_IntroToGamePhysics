using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movement = new Vector3(1.0f,0.0f,0.0f);
    private float timer = 1.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        timer -= Time.fixedDeltaTime;
        if (timer <0.0f)
        {
    	    ChangeDirection();
        }
        rb.MovePosition(transform.position + movement * Time.fixedDeltaTime);
    }

    void ChangeDirection()
    {
        movement = -1.0f * movement;
        timer = 1.0f;
    }
}
