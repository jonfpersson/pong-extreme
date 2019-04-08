using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour {

    public Rigidbody2D rb;
    public int speed;
	// Use this for initialization
	void Start () {
        int rand = Random.Range(0, 2);
        if(rand == 1)
            rb.velocity = new Vector2(-speed,0);
        else
            rb.velocity = new Vector2(speed, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "blue paddle")
        {
            float dist = GameObject.Find("blue paddle").transform.position.y - transform.position.y;
            triggerBounce(dist);
        } else if (collision.gameObject.name == "red paddle")
        {
            float dist = GameObject.Find("red paddle").transform.position.y - transform.position.y;
            triggerBounce(dist);
        }
    }
        
    public void triggerBounce(float dist)
    {
        if (dist > 0)
            rb.velocity = new Vector2(rb.velocity.x, 12);
        else if (dist == 0)
        {
            //Go Straight
            //Fix later lmao
        }
        else
            rb.velocity = new Vector2(rb.velocity.x, -12);
    }

    public void Update(){
        if (colission.isGameOver)
        rb.velocity = new Vector2(0, 0);
    }
}
