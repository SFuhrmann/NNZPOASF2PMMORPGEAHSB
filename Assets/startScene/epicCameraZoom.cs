using UnityEngine;
using System.Collections;

public class epicCameraZoom : MonoBehaviour {

	public float vSpeed;
	public GameObject[] logoObjects;
	private bool ready;
    public GameObject musicLoop;
    public GameObject wimpyLoop;
    public Animator bushes;

	private float runningTime;
	// Use this for initialization
	void Start () {
	
	}

    void Awake()
    {
        DontDestroyOnLoad(musicLoop);
        DontDestroyOnLoad(wimpyLoop);
    }
	
	// Update is called once per frame
	void Update () {
		if (!ready) {
			animate ();
			runningTime += Time.deltaTime;
		}
	
	}
	void animate () {
		int index = (int)((runningTime) / 0.7f);
		if (index < logoObjects.Length) {
				logoObjects [index].SetActive (true);
            if (index == 7)
                bushes.SetTrigger("bushes");
		} else {
				ready = true;
                musicLoop.GetComponent<AudioSource>().Play();
                wimpyLoop.GetComponent<AudioSource>().Play();
		}
	}
}
