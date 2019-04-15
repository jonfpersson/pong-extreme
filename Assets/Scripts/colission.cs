using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colission : MonoBehaviour {

    public GameObject gameOverTxt;
    public static bool isGameOver;
    public AudioSource audioSoruce;
    public AudioClip bruh;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "west" || collision.gameObject.name == "east")
        {
            //Debug.Log("Game over");
            gameOverTxt.SetActive(true);
            isGameOver = true;
        }

        audioSoruce.PlayOneShot(bruh);
    }
}
