using UnityEngine;
using System.Collections;

public class _ObjPaperController : ObjController {
	public AudioSource polish;
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
        if (col.CompareTag("Stain"))
        {
            GameManager.instance.setCleanedCoffeeStainDone();
            Destroy(col.gameObject);
        }
        else if (col.CompareTag("OrcBooger"))
        {
			polish.Play ();
            if (GameManager.instance.setTrashedOrcDone())
            {
                Destroy(col.gameObject);
            }
        }
		else if (!GameManager.instance.trashedOrc)
			ToolTipController.instance.setToolTip ("Da gibt es nichts wegzuwischen");
        /*if (col.CompareTag("Enemy"))
        {
            GameManager.instance.setThrownPaperDone();
        }*/
	}

    void OnMouseUp()
    {
        base.OnMouseUp();
        if (transform.position.y > 4)
        {
            if (GameManager.instance.setThrownPaperDone())
                Destroy(gameObject);
        }
    }
}
