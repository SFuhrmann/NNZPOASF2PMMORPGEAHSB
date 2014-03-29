using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public bool zoomingIN = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (zoomingIN) {
						cameraZoomIN ();
		} else {
						cameraZoomOUT ();
		}
	}
	void cameraZoomIN () {
		if (Camera.main.orthographicSize >= 2.5f) {
				Camera.main.orthographicSize -= 0.1f;
		}
		if (Camera.main.transform.position.x >= -2f) {
				Camera.main.transform.Translate (-0.1f, 0, 0);
		}
		if (Camera.main.transform.position.y <= 2.2f) {
				Camera.main.transform.Translate (0, 0.1f, 0);
		}
		if (Camera.main.orthographicSize <= 2.5f) {
			//this.zoomingIN = false;
			//Debug.Log ("Zoomed IN");
			Camera.main.orthographicSize = 2.5f;
		}
	}
	void cameraZoomOUT () {
		if (Camera.main.orthographicSize <= 5.0f) {
			Camera.main.orthographicSize += 0.1f;
		}
		if (Camera.main.transform.position.x < 0f) {
			Camera.main.transform.Translate (0.1f, 0, 0);
		}
		if (Camera.main.transform.position.y > 0f) {
			Camera.main.transform.Translate (0, -0.1f, 0);
		}
		if (Camera.main.orthographicSize >= 5.0f) {
			//Debug.Log ("Zoomed OUT");
			Camera.main.orthographicSize = 5.0f;
			//this.zoomingIN = true;
		}
	}
}
