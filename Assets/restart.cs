using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.name == "kiri" || other.collider.name == "kanan"){
            GetComponent<Transform>().position = new Vector2(-9.53f, 3.58f);
        }
    }
}
