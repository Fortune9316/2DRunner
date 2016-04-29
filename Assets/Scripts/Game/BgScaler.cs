﻿using UnityEngine;
using System.Collections;

public class BgScaler : MonoBehaviour {

	// Use this for initialization
	Renderer render;
	float width,height;
	void Start () {
		render = GetComponent<Renderer> ();
		//el alto y ancho de la pantalla
		height = Camera.main.orthographicSize*2f;
		width = height * Screen.width / Screen.height;
		transform.transform.localScale = new Vector3 (width, height, 0);

	
	}
	

}
