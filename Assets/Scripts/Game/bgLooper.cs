using UnityEngine;
using System.Collections;

public class bgLooper : MonoBehaviour {

    // Use this for initialization
    Material mat;
    Vector2 offset;
    public float speed;
	void Start () {
        mat = GetComponent<Renderer>().material;
        offset = mat.GetTextureOffset("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
        offset.x += speed * Time.deltaTime;
        mat.SetTextureOffset("_MainTex", offset);
	}
}
