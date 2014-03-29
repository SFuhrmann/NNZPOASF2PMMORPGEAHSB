using UnityEngine;
using System.Collections;

public class _ObjPictureofGirlfriendController : ObjController {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        //base.Update();
	}

    void OnTriggerStay2D(Collider2D col)
    {
        if (dragging || !draggingReady) return;
        print("collides picture");
    }

	void OnMouseDown()
	{
		if (GameManager.instance.paintedGirlfriendPhoto)
			ToolTipController.instance.setToolTip("Jetzt gefällt sie mir besser");
		else
			ToolTipController.instance.setToolTip("Meine Frau war auch schon mal hübscher");
	}

}
