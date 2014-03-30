using UnityEngine;
using System.Collections;

public class _playController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() {
		Camera.main.GetComponent<CameraScript> ().zoomingIN = false;
	}

}
