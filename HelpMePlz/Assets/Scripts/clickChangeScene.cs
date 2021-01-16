using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class clickChangeScene : MonoBehaviour
{
    public int Scene;
    public void LoadScene()
    {

        BallFix.Score = 0;
        BallFix.point = 4;
        Ally.win = 1;
        SceneManager.LoadScene(Scene);
    }

}
