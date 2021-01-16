using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    private bool isPressed = false;
    public int speed = 50;
    private float smooth = 0.5f;

    void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * smooth * Time.deltaTime, 0, 0, 0);
    }
}
