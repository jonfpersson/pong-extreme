using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleControl : MonoBehaviour {

    public Rigidbody2D rb1;
    public Rigidbody2D rb2;
    public int speed = 8;
	
    void FixedUpdate()
    {
        if (!colission.isGameOver)
        {
            float blueMoveVertical = Input.GetAxisRaw("wasd");
            Vector2 blueMovement = new Vector2(0, blueMoveVertical);
            rb1.velocity = blueMovement * speed;

            //Blue vs Red

            float redMoveVertical = Input.GetAxisRaw("udlr");
            Vector2 redMovement = new Vector2(0, redMoveVertical);
            rb2.velocity = redMovement * speed;
        }
    }
}
