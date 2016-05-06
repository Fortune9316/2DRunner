using UnityEngine;
using System.Collections;

public class CamerMovement : MonoBehaviour {

    // Use this for initialization
    Player player;
    float distancetoMove;
    bool isCreated;
    string current;
    public bool isMoving;
    public static CamerMovement instance;

    void Awake()
    {
        instance = this;
    }
	void Start () {
        isMoving = true;
        current = PlayerPrefs.GetString("color", "green");
        
	}
	
	// Update is called once per frame
	void Update () {
        
        if(isMoving)
        if(!isCreated)
        {
            player = GameObject.Find(current).GetComponent<Player>();
            if(player != null)
            {
                isCreated = true;
            }
        }
        else
        {
            distancetoMove = player.transform.position.x - transform.position.x;
            transform.position = new Vector3(distancetoMove + transform.position.x, transform.position.y, transform.position.z);
        }
	}
}
