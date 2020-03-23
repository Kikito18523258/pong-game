using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_script : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed=10;

    void Start()
    {
        Debug.Log("Hello World!");
        GetComponent<Rigidbody2D>().velocity = new Vector2(2,2) * speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
