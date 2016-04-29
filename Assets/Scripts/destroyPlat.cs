using UnityEngine;
using System.Collections;

public class destroyPlat : MonoBehaviour {

    // Use this for initialization

    GameObject collector;
	void Start () {
        collector = GameObject.Find("plataformCollector");
	}
	
	// Update is called once per frame
	void Update () {
        if (collector.transform.position.x >= this.transform.position.x)
            Destroy(gameObject);
	}
}
