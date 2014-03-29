using UnityEngine;
using System.Collections;

public class _ObjPaperController : ObjController {

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
        if (col.CompareTag("OrcBooger"))
        {
            if (GameManager.instance.setTrashedOrcDone())
            {
                Destroy(col.gameObject);
            }
        }
        if (col.CompareTag("Enemy"))
        {
            GameManager.instance.setThrownPaperDone();
        }
	}
}
