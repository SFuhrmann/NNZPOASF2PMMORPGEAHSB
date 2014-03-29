using UnityEngine;
using System.Collections;

public class _ObjPenController : ObjController {

	public AudioSource pen;
	public AudioSource penDraw;

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
        if (col.CompareTag("PictureOfGirlfriend"))
        {
            GameManager.instance.setPaintedGirlfriendPhotoDone();
			penDraw.Play();
        }
	}
}
