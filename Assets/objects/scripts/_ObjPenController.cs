using UnityEngine;
using System.Collections;

public class _ObjPenController : ObjController {

	public AudioSource pen;
    public GameObject breastMenu;

	void Start () {
		toolTipMessage = "Das ist dein Stift";
	}

	void Update () {
		
		base.Update();
	}
	
	void OnTriggerStay2D(Collider2D col)
	{
		if (dragging || !draggingReady) return;
        if (col.CompareTag("Bin"))
        {
            GameManager.instance.setTrashedPencilDone(gameObject);
			pen.Play();
        }
        else if (col.CompareTag("PictureOfGirlfriend"))
        {
            breastMenu.SetActive(true);
        }
		else
		{
			ToolTipController.instance.setToolTip("Da will ich nichts schreiben");
		}
	}
}
