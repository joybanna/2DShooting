using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoresys : MonoBehaviour
{

    public Text Life;
    public Text Score;

    void Update()
    {
        Life.text = "Life:" + BallFix.point;
        Score.text = "Score:" + BallFix.Score;
    }
}
