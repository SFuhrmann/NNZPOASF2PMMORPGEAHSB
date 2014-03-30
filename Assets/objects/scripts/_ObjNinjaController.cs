using UnityEngine;
using System.Collections;

public class _ObjNinjaController : ObjController {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        base.Update();
	}

    void OnTriggerStay2D(Collider2D col)
    {
		if (Camera.main.GetComponent<CameraScript>().zoomingIN) return;
        if (dragging || !draggingReady) return;
        if (col.CompareTag("Bin"))
        {
            GameManager.instance.setDeletedDesktopNinjaDone(gameObject);
        }
		else
		{
			ToolTipController.instance.setToolTip("Was mach ich nur mit dem Ninja?");
		}
    }
}
