using UnityEngine;
using System.Collections;

public class PlataformGenerator : MonoBehaviour {

    // Use this for initialization
    public GameObject[] plataforms;
    private float[] platformsWidth;
    public int minWidth;
    public int maxWidth;
    public int distanceToPlatform;

    private float maxDistanceHeight;
    private float minDistanceHeight;
    public Transform maxPointDistanceHeight;

    public Transform generationPoint;

    private float distanceChange;
	void Start () {
        platformsWidth = new float[plataforms.Length];
        for(int i = 0; i< plataforms.Length; i++)
        {
            platformsWidth[i] = plataforms[i].GetComponent<BoxCollider2D>().size.x;
        }

        minDistanceHeight = transform.position.y;
        maxDistanceHeight = maxPointDistanceHeight.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < generationPoint.position.x)
        {
            int random = Random.Range(0, plataforms.Length);

            distanceToPlatform = Random.Range(minWidth, maxWidth);

            distanceChange = transform.position.y + (Random.Range(maxDistanceHeight, -maxDistanceHeight));

            distanceChange = Mathf.Clamp(distanceChange, minDistanceHeight, maxDistanceHeight);

            transform.position = new Vector3(transform.position.x + (platformsWidth[random] / 2) + distanceToPlatform, transform.position.y, transform.position.z);

            GameObject go = Instantiate(plataforms[random], new Vector3(transform.position.x + platformsWidth[random] + distanceToPlatform, transform.position.y, transform.position.z), Quaternion.identity) as GameObject;

            transform.position = new Vector3(transform.position.x + (platformsWidth[random] / 2) + distanceToPlatform, transform.position.y, transform.position.z);
        }
	}
}
