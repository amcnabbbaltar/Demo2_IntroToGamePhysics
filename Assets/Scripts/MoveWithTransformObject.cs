using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectWithTransform : MonoBehaviour
{
    public Vector3 movement = new Vector3();
    public float timeScale = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = timeScale;
        // 1. Move object with Translate
            transform.Translate(movement* Time.deltaTime);
        // 2. Move object by changing the position directly
            //transform.position += movement * Time.deltaTime;
    }
}
