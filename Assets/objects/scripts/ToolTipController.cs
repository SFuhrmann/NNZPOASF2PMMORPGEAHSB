using UnityEngine;
using System.Collections;

public class ToolTipController : MonoBehaviour {

    public GUISkin skin;
	public GameObject archieveBG;
	public GameObject hintBG;
    public TextMesh achieveText, hintText;

	private string instanceToolTip = "";
    private float cooldownTime = 0f;
    private bool cooldownIsRunning = false;
	private bool hint = true;


	internal static ToolTipController instance;

	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
        if (cooldownIsRunning)
        {
            if (cooldownTime > 0)
                cooldownTime -= Time.deltaTime;
            else
            {
                cooldownIsRunning = false;
				instanceToolTip = "";
				archieveBG.SetActive(false);
				hintBG.SetActive(false);
			}
		}
	}

    /*void OnGUI()
    {
        GUI.skin = skin;
		GUI.contentColor = Color.black;
		if (this.hint == true) {
			GUI.Label(new Rect(20, 20, Screen.width, 100), instanceToolTip);
		} else {
			GUI.Label(new Rect(425, 250, Screen.width, 500), instanceToolTip);
		}
    }*/

	public void setToolTip(string toolTip, bool hint = true) {
		if (hint == false) {
			this.hint = false;
			achieveText.text = toolTip;
            //print(achieveText.text);
			cooldownTime = 3f;			cooldownIsRunning = true;
			hintBG.SetActive(false);
			archieveBG.SetActive(true);
            GetComponent<AudioSource>().Play();
		} else {
			this.hint = true;
            hintText.text = toolTip;
            //print(hintText.text);
			cooldownTime = 3f;
			cooldownIsRunning = true;
			hintBG.SetActive(true);
		}
        

	}
}
