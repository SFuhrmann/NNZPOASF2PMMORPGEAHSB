using UnityEngine;
using System.Collections;

public class ChecklistController : MonoBehaviour {

    public GameObject[] listCheckMarks;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void checkListItem(int number)
    {
        listCheckMarks[number].GetComponent<SpriteRenderer>().enabled = true;
        //listCheckMarks[number].GetComponent<Animator>().SetTrigger("Checked");
    }
}
