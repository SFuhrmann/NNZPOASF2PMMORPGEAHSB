using UnityEngine;
using System.Collections;

public class DialDummy : MonoBehaviour {

    public _ObjPhoneController phone;
    public int number;

	// Use this for initialization
    void Start()
    {
	
	}
	
	// Update is called once per frame
    void Update()
    {

	}

    void OnMouseDown()
    {
        phone.phoneSprite.sprite = phone.pressedDownSprites[number];
        phone.addNewNumber(number);
        GetComponent<AudioSource>().Play();
    }
}
