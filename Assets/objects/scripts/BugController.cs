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
        GetComponent<SpriteRenderer>().sprite = bugDead;
        GetComponent<AudioSource>().Play();
    }
}
