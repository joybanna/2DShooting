using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSound : MonoBehaviour {
    public AudioClip wood;
    AudioSource audioSource;
    public GameObject block;
    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        
        audioSource.PlayOneShot(wood);
    }

}
