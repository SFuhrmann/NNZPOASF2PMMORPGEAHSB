using UnityEngine;
using System.Collections;

public class _ObjPenController : ObjController {

	void Start () {
		toolTipMessage = "Das ist dein Stift";
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
