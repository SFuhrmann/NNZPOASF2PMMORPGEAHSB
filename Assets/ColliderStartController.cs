using UnityEngine;
using System.Collections;

public class ColliderStartController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() {
        if (!GameObject.Find("MusicLoop").GetComponent<AudioSource>().isPlaying)
        {
            GameObject.Find("MusicLoop").GetComponent<AudioSource>().Play();
            GameObject.Find("WimpyLoop").GetComponent<AudioSource>().Play();
        }
		Application.LoadLevel ("scene");
	}
}
