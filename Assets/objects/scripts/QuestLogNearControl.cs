using UnityEngine;
using System.Collections;

public class QuestLogNearControl : MonoBehaviour {
	public AudioSource close;
    public GameObject checklistSmall;
	// Use this for initialization
	void Start () {

	}

    // Update is called once per frame
    void Update()
    {
	
	}

    void OnMouseDown()
    {
		close.Play ();
        gameObject.SetActive(false);
        checklistSmall.SetActive(true);
    }
}
