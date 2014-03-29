using UnityEngine;
using System.Collections;

public class MouseController : ObjController {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnSwipeUp() { 
		//do something sweet
		Debug.Log ("swipe up");
	}
	void OnSwipeRight() { 
		//do something awesome
		Debug.Log ("swipe right");
	}
	void OnSwipeDown() { 
		//do something great
		Debug.Log ("swipe down");
	}
	void OnSwipeLeft() { 
		//do something nice
		Debug.Log ("swipe left");
	}
}
