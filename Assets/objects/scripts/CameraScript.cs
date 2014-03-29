using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public float ortographicZoomIn;
	public float zoomInX;
	public float zoomInY;
	public bool zoomingIN = false;

	public GameObject GameMenu;
	public GameObject Ingame;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (zoomingIN) {
			cameraZoomIN ();
			GameMenu.SetActive(true);
			Ingame.SetActive(false);

		} else {
			cameraZoomOUT ();
			GameMenu.SetActive(false);
			Ingame.SetActive(true);
		}
	}
	void cameraZoomIN () {
		if (Camera.main.transform.position.x >= zoomInX) {
				Camera.main.transform.Translate (-0.1f, 0, 0);
		}
		if (Camera.main.transform.position.y <= zoomInY) {
				Camera.main.transform.Translate (0, 0.1f, 0);
		}
		if (Camera.main.orthographicSize >= ortographicZoomIn) {
			Camera.main.orthographicSize -= 0.1f;
		}
		if (Camera.main.orthographicSize <= ortographicZoomIn) {
			//this.zoomingIN = false;
			//Debug.Log ("Zoomed IN");
			Camera.main.orthographicSize = ortographicZoomIn;
		}
	}
	void cameraZoomOUT () {

		if (Camera.main.transform.position.x < 0f) {
			Camera.main.transform.Translate (0.1f, 0, 0);
		}
		if (Camera.main.transform.position.y > 0f) {
			Camera.main.transform.Translate (0, -0.1f, 0);
		}
		if (Camera.main.orthographicSize <= 5.0f) {
			Camera.main.orthographicSize += 0.1f;
		}
		if (Camera.main.orthographicSize >= 5.0f) {
			//Debug.Log ("Zoomed OUT");
			Camera.main.orthographicSize = 5.0f;
			//this.zoomingIN = true;
		}
	}

}
