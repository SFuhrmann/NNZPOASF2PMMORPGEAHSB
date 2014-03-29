using UnityEngine;
using System.Collections;

public class BugController : MonoBehaviour {

    public Sprite bugDead;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
		if (!GameManager.instance.fixedBug) 
		{
			GetComponent<SpriteRenderer>().sprite = bugDead;
			GetComponent<AudioSource>().Play();
			ToolTipController.instance.setToolTip("Den Bug gefunden.", false);
			GameManager.instance.fixedBug = true;
		}
        
    }
}
