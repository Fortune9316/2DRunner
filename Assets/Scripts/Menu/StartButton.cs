using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//sacado del global namespace Runner.Utils
using Runner.Utils;

public class StartButton : MonoBehaviour {

	// Use this for initialization

	void Start () {
		
	
	}
    public void enableClick()
    {
        GetComponent<Button>().onClick.AddListener(() => goChooser());
    }
	void goChooser(){
        GetComponent<Button>().onClick.RemoveAllListeners();
        SceneManager.LoadScene (Global.PLAYER_SELECTION);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
