using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLose : MonoBehaviour {
    public GameObject WinText;
    public GameObject LoseText;

    // Use this for initialization
    void Start () {
        if (Ally.win == 0)
        {
            WinText.SetActive(true);
            LoseText.SetActive(false);

        }
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
