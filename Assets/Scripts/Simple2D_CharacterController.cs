using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpStrength = 100;
    public float moveStrenght = 100;
    public bool triggerJump = false;
    public float horizontal = 0.0f;
    public float vertical = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        
        if(Input.GetButtonUp("Jump"))
        {
            triggerJump = true;
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {   
        horizontal = Input.GetAxis("Horizontal");
        rb.AddForce(Vector3.right * horizontal * moveStrenght);
        if (triggerJump)
        {
            rb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
            
            triggerJump=false;
        }
    }
}
