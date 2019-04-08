using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSongs : MonoBehaviour {

    public AudioSource au;

    public AudioClip blueHitler;
    public AudioClip hentaiSounds;
    public AudioClip mineDiamonds;
    public AudioClip monsterInc;
    public AudioClip rickroll;
    public AudioClip weAreNumberBork;


    // Use this for initialization
    void Start () {

        int rand = Random.Range(0, 7);
        
        switch (rand)
        {
            
            case 1:
                au.PlayOneShot(hentaiSounds);
                break;
            case 2:
                au.PlayOneShot(mineDiamonds);
                break;
            case 3:
                au.PlayOneShot(monsterInc);
                break;
            case 4:
                au.PlayOneShot(rickroll);
                break;
            case 5:
                au.PlayOneShot(weAreNumberBork);
                break;
            case 6:
                au.PlayOneShot(blueHitler);
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
