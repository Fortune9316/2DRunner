using UnityEngine;
using System.Collections;

public class BackgroundSpawner : MonoBehaviour {

    // Use this for initialization
    private GameObject[] bgs;
    private float lastX;
	void Start () {
        bgs = GameObject.FindGameObjectsWithTag("Background");
        lastX = bgs[0].transform.position.x;
        for(int i=0; i<bgs.Length;i++)
        {
            if(lastX < bgs[i].transform.position.x)
            {
                lastX = bgs[i].transform.position.x;
            }
        }
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D coll)
    {
        
        if(coll.gameObject.transform.position.x == lastX)
        {
            Vector3 tmp = coll.gameObject.transform.position;
            float width = ((BoxCollider2D)coll).size.x;
            for(int i = 0; i < bgs.Length; i++)
            {
                if (!bgs[i].activeInHierarchy)
                {
                    tmp.x += width;
                    bgs[i].transform.position = tmp;
                    lastX = tmp.x;
                    bgs[i].SetActive(true);
                }
            }
        }
    }
}
