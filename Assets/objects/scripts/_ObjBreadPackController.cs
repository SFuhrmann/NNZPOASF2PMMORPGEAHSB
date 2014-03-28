using UnityEngine;
using System.Collections;

public class _ObjBreadPackController : ObjController {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //
    void OnSwipeUp()
    {
        GameManager.instance.setOpenedBreadPackDone();
    }
}
