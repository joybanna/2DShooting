using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickChangeScene : MonoBehaviour {

    // Use this for initialization
    public int Scene;
  
	void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void LoadScene()
    {

        BallFix.Score = 0;
        BallFix.point = 4;
        Ally.win = 1;
        SceneManager.LoadScene(Scene);
    }
    
}
