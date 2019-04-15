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

    public int OldId;
    // Use this for initialization
    void Start () {
        OldId = -1;
        InvokeRepeating("playSong", 0.01f, 8);
        
    }
	
	// Update is called once per frame
	void Update () {
    }

    void playSong()
    {
        au.Stop();
        int id = Random.Range(1, 6);


        if (id == OldId)
        {
            id = Random.Range(1, 6);
            randSong(id);
        }
        randSong(id);

        Debug.Log(id);
        
    }

    public void randSong(int id)
    {
        switch (id)
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
        OldId = id;
    }
}
