using UnityEngine;
using System.Collections;

public class _ObjPhoneController : ObjController {

    public GameObject[] dialDummy;
    public Sprite nonPressedSprite;
    public Sprite[] pressedDownSprites;
    public SpriteRenderer phoneSprite;
    public AudioSource bgm;
    private int[] lastDialedNumbers = new int[3];
    private float pressedTimer = 0;
    public float pressedTime = 0.5f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
    void Update()
    {
        if (pressedTimer > 0)
        {
            pressedTimer -= Time.deltaTime;
        }
        else
        {
            pressedTimer = 0;
            phoneSprite.sprite = nonPressedSprite;
        }	
	}
	void OnSwipeUp() { 
		//do something sweet
		Debug.Log ("swipe up");
	}
	void OnSwipeRight() { 
		//do something awesome
		Debug.Log ("swipe right");
	}
	void OnSwipeDown() { 
		//do something great
		Debug.Log ("swipe down");
	}
	void OnSwipeLeft() { 
		//do something nice
		Debug.Log ("swipe left");
	}

    public void addNewNumber(int i)
    {
        lastDialedNumbers[2] = lastDialedNumbers[1];
        lastDialedNumbers[1] = lastDialedNumbers[0];
        lastDialedNumbers[0] = i;
        print(lastDialedNumbers[0] + " " + lastDialedNumbers[1] + " " + lastDialedNumbers[2]);
        if (lastDialedNumbers[0] == 6 && lastDialedNumbers[1] == 6 && lastDialedNumbers[2] == 6)
        {
            GameManager.instance.setAnsweredPhoneCallDone();
            GetComponent<AudioSource>().Play();
            bgm.volume = 0;
            Invoke("resetBGMVolume", GetComponent<AudioSource>().clip.length - 1);
        }
        
        pressedTimer = pressedTime;
    }

    public void resetBGMVolume()
    {
        bgm.volume = 1;
    }
}
