using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Runner.Utils;

public class PlayerChooser : MonoBehaviour {


	//Aparece en la pantalla para arrastrar
	public Button blue,yellow;
	public Button pink,green;
	string player;

	// Use this for initialization
	void Start () {

		yellow.onClick.AddListener (() => chooseYellow ());
		pink.onClick.AddListener (() => choosePink ());
		green.onClick.AddListener (() => chooseGreen ());
		blue.onClick.AddListener (() => chooseBlue ());

	}
	void chooseYellow(){
		player = "yellow";
			goGame();
	}
	void choosePink(){
		player = "pink";
			goGame();
	}
	void chooseGreen(){
		player = "green";
			goGame();
	}
	void chooseBlue(){
		player = "blue";
			goGame();
	}
	void goGame(){
		//pasa var de una escena a otro
		PlayerPrefs.SetString ("color", player);
		SceneManager.LoadScene (Global.GAME);
	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
