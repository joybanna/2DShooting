﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPointBlock : MonoBehaviour
{
    public float healthPoint = 4f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > healthPoint && (collision.gameObject.tag == "Player1" || collision.gameObject.tag == "Player"))
        {
            die();
        }
    }
    void die()
    {
        this.gameObject.SetActive(false);
    }
}
