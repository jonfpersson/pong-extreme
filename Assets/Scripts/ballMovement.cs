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
        {
            rb.velocity = new Vector2(-speed,0);
        }
        else
        {
            rb.velocity = new Vector2(speed, 0);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "blue paddle")
        {
            float dist = GameObject.Find("blue paddle").transform.position.y - transform.position.y;
            Debug.Log("dist: " + dist);

            if(dist > 0)
            {
                //Go Up
            }
            else if(dist == 0)
            {
                //Go Straight

            }
            else
            {
                //Go Down

            }

        }
    }
        

    // Update is called once per frame
    void Update () {
		


	}
}
