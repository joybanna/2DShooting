using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 4f;
    public GameObject dieEF;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > health && (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player"))
        {
            Instantiate(dieEF, transform.position, Quaternion.identity);
            BallFix.Score += 3;
            Die();
        }
    }
    void Die()
    {
        this.gameObject.SetActive(false);
    }
}
