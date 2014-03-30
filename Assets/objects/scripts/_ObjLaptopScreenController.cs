using UnityEngine;
using System.Collections;

public class _ObjLaptopScreenController : ObjController {

    AudioSource bgmEpic, bgmWimpy;
    public float fadeTimer;
    public float fadeTime = 1.0f;
    public SpriteRenderer cover;

    // Use this for initialization
	void Start () {
	    
	}

    void Awake ()
    {
        bgmEpic = GameObject.Find("MusicLoop").GetComponent<AudioSource>();
        bgmWimpy = GameObject.Find("WimpyLoop").GetComponent<AudioSource>();
        if (Camera.main.GetComponent<CameraScript>().zoomingIN)
        {
            Camera.main.GetComponent<CameraScript>().zoomingIN = false;
            fadeTimer = fadeTime;
        }
    }

	// Update is called once per frame
	void Update () {
        if (!Camera.main.GetComponent<CameraScript>().zoomingIN)
        {
            if (fadeTimer > 0)
            {
                fadeTimer -= Time.deltaTime;
                bgmEpic.volume = fadeTimer / fadeTime;
                bgmWimpy.volume = 1 - (fadeTimer / fadeTime);
            }
        }
        else
        {
            if (fadeTimer > 0)
            {
                fadeTimer -= Time.deltaTime;
                bgmEpic.volume = 1 - (fadeTimer / fadeTime);
                bgmWimpy.volume = fadeTimer / fadeTime;
            }
        }
	}

    void OnMouseDown()
    {
        
        if (!Camera.main.GetComponent<CameraScript>().zoomingIN)
            GameManager.instance.setUnhideDesktopNinjaDone();
    }
}
