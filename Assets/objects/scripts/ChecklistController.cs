using UnityEngine;
using System.Collections;

public class ChecklistController : MonoBehaviour {

	public static int NINJA_QUEST = 5;
	public static int ZOMBIE_QUEST = 0;
	public static int NAZI_QUEST = 1;
	public static int PIRATE_QUEST = 2;
	public static int ORC_QUEST = 3;
	public static int PVP_QUEST = 7;
	public static int GIRLFRIEND_QUEST = 4;
	public static int ALIEN_QUEST = 6;

	public AudioSource openSound;
	public AudioSource closeSound;

    public GameObject[] listCheckMarks;
    public GameObject questlogNear;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void checkListItem(int number)
    {
        listCheckMarks[number].SetActive(true);
        //listCheckMarks[number].GetComponent<Animator>().SetTrigger("Checked");
    }

    void OnMouseDown()
    {
        questlogNear.SetActive(true);
        
        openSound.Play();
        gameObject.SetActive(false);
    }
}
