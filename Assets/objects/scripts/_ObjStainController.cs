using UnityEngine;
using System.Collections;

public class _ObjStainController : ObjController {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown()
	{
		ToolTipController.instance.setToolTip("Ohje, ein Kaffeefleck");
	}
}
