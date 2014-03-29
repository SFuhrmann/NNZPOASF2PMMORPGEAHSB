using UnityEngine;
using System.Collections;

public class _ObjBreadPackController : ObjController {

    private bool openPack;
    public GameObject chocolate;
    public GameObject bananaSausage;

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {

        //base.Update();
	}

    void OnMouseDown()
    {
        if (!openPack)
        {
            openPack = true;
            chocolate.SetActive(true);
            bananaSausage.SetActive(true);
        }
    }

    /*void OnTriggerStay2D(Collider2D col)
    {
        if (dragging || !draggingReady) return;
        if (col.CompareTag(""))
        {

        }
    }*/
}
