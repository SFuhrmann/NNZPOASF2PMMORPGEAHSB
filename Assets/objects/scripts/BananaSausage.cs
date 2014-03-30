using UnityEngine;
using System.Collections;

public class BananaSausage : ObjController {

    public GameObject chocolate;

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
       /* if (col.CompareTag("Enemy"))
        {
            GameManager.instance.setThrownBananaSausageDone();
        }*/
    }

    void OnMouseUp()
    {
        base.OnMouseUp();
        if (transform.position.y > 4)
        {
            if (GameManager.instance.setThrownBananaSausageDone())
                Destroy(gameObject);
        }
        else if (transform.position.y < -4)
        {
            GameManager.instance.setTastedBananaSausageDone(gameObject);
        }
        else
            ToolTipController.instance.setToolTip("Was mach ich bloß damit?");
    }
}
