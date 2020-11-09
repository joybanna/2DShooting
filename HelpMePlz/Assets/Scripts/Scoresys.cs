using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoresys : MonoBehaviour {

    public Text Life;
    public Text Score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Life.text = "Life:" + BallFix.point;
        Score.text = "Score:" + BallFix.Score;
	}
}
