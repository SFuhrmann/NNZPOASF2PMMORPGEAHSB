using UnityEngine;
using System.Collections;

public class _ObjChocolate : ObjController {
	public AudioSource nom;

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
        /*if (col.CompareTag("Self"))
        {
            GameManager.instance.setEatenChocolateBarDone();
            Destroy(gameObject);
        }*/
    }

    void OnMouseUp()
    {
        base.OnMouseUp();
        if (transform.position.y < -4) 
        {
            GameManager.instance.setEatenChocolateBarDone();

            Destroy(gameObject);
        }
		else
			ToolTipController.instance.setToolTip("Oh Schokolade!");
    }
}
