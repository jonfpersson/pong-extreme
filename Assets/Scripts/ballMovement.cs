using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballMovement : MonoBehaviour {

    public Rigidbody2D rb;
    public int speed;
    int numberOfCollisions;
    public int offset = 12;

    Vector2 oldSpeed;

    public Transform westWall;
    public Transform eastWall;

    // Use this for initialization
    void Start () {
        numberOfCollisions = 0;
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
        numberOfCollisions++;
        offset++;

        if (numberOfCollisions > 1 && numberOfCollisions < 3)
        {
            if (dist > 0)
                rb.velocity = new Vector2(rb.velocity.x, offset);
            else
                rb.velocity = new Vector2(rb.velocity.x, -offset);
        }
       
    }

    public void Update(){
        if (colission.isGameOver)
            rb.velocity = new Vector2(0, 0);
        else if (!colission.isGameOver && goalEarrape.hasPlayedOnce)
            rb.velocity = oldSpeed;

        if (-8.4f > transform.position.x && !colission.isGameOver)
            oldSpeed = rb.velocity;
        else if (8.4f < transform.position.x && !colission.isGameOver)
            oldSpeed = rb.velocity;
    }
}
