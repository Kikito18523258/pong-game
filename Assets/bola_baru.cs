using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola_baru : MonoBehaviour
{
    public int speed= 10;
    private Rigidbody2D rb2d;
    
    void GoBall(){
    float rand = Random.Range(0, 2);
    if(rand < 1){
        rb2d.AddForce(new Vector2(20, -15));
    } else {
        rb2d.AddForce(new Vector2(-20, -15));
    }
}
    // Start is called before the first frame update
    
    void Start()
    {
        Debug.Log("Hello World!");
        GetComponent<Rigidbody2D>().velocity = new Vector2(2,2) * speed;
    //     rb2d = GetComponent<Rigidbody2D>().velocity = new Vector2(2,2) * speed;
    // Invoke("GoBall", 2);
    }

    // Update is called once per frame
    
    void ResetBall()
    {
        rb2d.velocity = Vector2.zero;
    transform.position = Vector2.zero;
    }
    
    void RestartGame(){
    ResetBall();
    Invoke("GoBall", 1);
    }

}

