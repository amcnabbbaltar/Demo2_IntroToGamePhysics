using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectWithForces : MonoBehaviour
{
    public Vector3 forceToApply = new Vector3();
    public Vector3 velocity = new Vector3();
     public Vector3 movement = new Vector3();
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // 1. Adding a force to push a object in a direction
        //rb.AddForce(forceToApply);
        // 2. Setting the velocity directly;
        //rb.velocity = velocity;
        // 3. Translating with the rigid body (Will not ignore collision when moving)
        //rb.MovePosition(movement * Time.deltaTime);
    }
}
