using UnityEngine;
using System.Collections;

public class BreastMenuItem : MonoBehaviour {

    public SpriteRenderer breasts;
    public AudioSource penDraw;
    public GameObject menu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        breasts.sprite = GetComponent<SpriteRenderer>().sprite;
        GameManager.instance.setPaintedGirlfriendPhotoDone();
        penDraw.Play();
        menu.SetActive(false);
    }
}
