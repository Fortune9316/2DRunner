using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverPanel : MonoBehaviour {

	// Use this for initialization
    [SerializeField]
    private Button start;
    [SerializeField]
    private Button quit;
    float posY;

    public static GameOverPanel instance;

    void Awake()
    {
        instance = this;
    }
	void Start () {
        start.onClick.AddListener(() => Restart());
        quit.onClick.AddListener(() => QuitApp());

        posY = transform.position.y;
        transform.position = new Vector3(transform.position.x, transform.position.y +10f, transform.position.z);
        
        
	}

    void Restart()
    {
        SceneManager.LoadScene("Game");
    }
    void QuitApp()
    {
        Application.Quit();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void show()
    {
        iTween.MoveTo(gameObject, iTween.Hash("y", posY));
    }
}
