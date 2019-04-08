using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Return) && colission.isGameOver)
        {
            SceneManager.LoadScene("Main");
            colission.isGameOver = false;
        }
    }
}
