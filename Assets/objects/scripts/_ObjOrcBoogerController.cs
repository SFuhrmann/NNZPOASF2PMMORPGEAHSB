using UnityEngine;
using System.Collections;

public class _ObjOrcBoogerController : ObjController {

	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
		base.Update();
	}
	
	void OnTriggerStay2D(Collider2D col)
	{
		if (dragging || !draggingReady) return;
		print("collides booger");
	}

	void OnMouseDown()
	{
		ToolTipController.instance.setToolTip("Den Popel sollte ich mal wegwischen");
	}

}
