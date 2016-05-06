using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class Video : MonoBehaviour {

    // Use this for initialization
    public MovieTexture movie;
    AudioSource source;
	void Start () {
        GetComponent<RawImage>().texture = movie as MovieTexture;
        source = GetComponent<AudioSource>();
        source.clip = movie.audioClip;
        movie.Play();
        source.Play();
        Invoke("completeVideo", movie.duration);
	}
	
	// Update is called once per frame
	void Update () {
        

    }
}
