using UnityEngine;
using System.Collections;

public class _ObjLaptopScreenController : ObjController {

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (Camera.main.GetComponent<CameraScript>().zoomingIN)
            Camera.main.GetComponent<CameraScript>().zoomingIN = false;
        else
			GameManager.instance.setUnhideDesktopNinjaDone();
    }
}
