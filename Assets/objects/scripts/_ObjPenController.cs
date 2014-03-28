using UnityEngine;
using System.Collections;

public class _ObjPenController : ObjController {

	void Start () {
		toolTipMessage = "Das ist dein Stift";
	}

	void OnSwipeRight ()
	{
		Debug.Log ("swipe right");
	}
}
