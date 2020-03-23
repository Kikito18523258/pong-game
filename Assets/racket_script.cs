﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racket_script : MonoBehaviour
{
    public float speed = 12;
    public KeyCode moveUp = KeyCode.W;
    public KeyCode moveDown = KeyCode.S;
    // public float speed = 12.0f;
    public float boundY = 2.25f;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
    if (Input.GetKey(moveUp)) {
        vel.y = speed;
    }
    else if (Input.GetKey(moveDown)) {
        vel.y = -speed;
    }
    else {
        vel.y = 0;
    }
    rb2d.velocity = vel;
    }
}
