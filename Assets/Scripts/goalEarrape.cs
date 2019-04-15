using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalEarrape : MonoBehaviour {

    public AudioSource ad;
    public Transform ballPos;
    public Transform bluePadPos;
    public Transform redPadPos;

    public AudioClip naniSound;
    public static bool hasPlayedOnce;

    public GameObject naniCam;


    // Use this for initialization
    void Start () {
        hasPlayedOnce = false;

    }
	
	// Update is called once per frame
	void Update () {
        
        if(ballPos.position.x < bluePadPos.position.x- +0.8f || ballPos.position.x > redPadPos.position.x+0.8f)
        {
            if (!hasPlayedOnce)
            {
                colission.isGameOver = true;
                naniCam.SetActive(true);
                ad.PlayOneShot(naniSound);
                hasPlayedOnce = true;

            }

            if (!ad.isPlaying && hasPlayedOnce)
            {
                colission.isGameOver = false;
            }
        }

    }
}
