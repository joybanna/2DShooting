using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ally : MonoBehaviour
{
    public static int win = 1;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            BallFix.Score += 10;
            win--;
            LoadScene();
        }
    }
    public void LoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(2);
    }
}
