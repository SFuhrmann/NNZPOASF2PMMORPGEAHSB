using UnityEngine;
using System.Collections;

public class _ObjCoffeeCupController : ObjController {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();
	}

    void OnTriggerStay2D(Collider2D col)
    {
        if (dragging || !draggingReady) return;
        print("collides coffeecup");
    }
}
