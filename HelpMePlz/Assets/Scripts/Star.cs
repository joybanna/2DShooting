using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player1")
        {
            BallFix.point++;
            BallFix.Score++;
            die();
        }
    }
    void die()
    {
        Destroy(this.gameObject);
    }
}
