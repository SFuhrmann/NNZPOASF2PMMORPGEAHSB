using UnityEngine;
using System.Collections;

public class BananaSausage : ObjController {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (dragging || !draggingReady) return;
        if (col.CompareTag("Enemy"))
        {
            GameManager.instance.setThrownBananaSausageDone();
        }
    }
}
