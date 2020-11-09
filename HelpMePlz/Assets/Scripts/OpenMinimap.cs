using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenMinimap : MonoBehaviour {
    public int numClick = 1;
    public GameObject minimap;
    // Use this for initialization
    void Start () {
        Button openminimap = gameObject.GetComponent<Button>();
        openminimap.onClick.AddListener(Close);
        
    }
	
	// Update is called once per frame
	void Update () {
	}
    
   
    public void Close()
    {
        numClick++;

        if (numClick % 2 == 0)
        {
            minimap.SetActive(false);
        }
        else
        { 
            minimap.SetActive(true);
        }
    }

}
