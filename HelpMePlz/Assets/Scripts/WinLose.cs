using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour
{
    public GameObject WinText;
    public GameObject LoseText;
    void Start()
    {
        if (Ally.win == 0)
        {
            WinText.SetActive(true);
            LoseText.SetActive(false);

        }

    }
}
