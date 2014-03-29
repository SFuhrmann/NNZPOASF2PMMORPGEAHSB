using UnityEngine;
using System.Collections;

public class epicCameraZoom : MonoBehaviour {

	public float vSpeed;
	public GameObject[] logoObjects;
	private bool ready;

	private float runningTime;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!ready) {
			animate ();
			runningTime += Time.deltaTime;
		}
	
	}
	void animate () {
		int index = (int)((runningTime) / 0.7f);
		if (index < logoObjects.Length) {
				logoObjects [index].SetActive (true);
		} else {
				ready = true;
		}
	}
}
