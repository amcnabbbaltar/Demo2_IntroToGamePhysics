using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCollisionScript : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        //Debug.Log("OnEnter :"+other.gameObject.name);
        if (other.gameObject.tag=="Enemy")
        {
            Debug.Log("I hit the enemy");
            Destroy(other.gameObject);
        }
    }
    void OnCollisionExit(Collision other)
    {
       Debug.Log("OnExit :"+other.gameObject.name);

    }
    void OnCollisionStay(Collision other)
    {
        Debug.Log("OnStay:"+other.gameObject.name);

    }
    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("OnTriggerEnter "+ collider.gameObject.name);
    }
    void OnTriggerExit(Collider collider)
    {
        Debug.Log("OnTriggerExit "+ collider.gameObject.name);
    }
    void OnTriggerStay(Collider collider)
    {
        Debug.Log("OnTriggerStay"+ collider.gameObject.name);
    }
}
