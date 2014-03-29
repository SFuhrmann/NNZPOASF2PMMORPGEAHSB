using UnityEngine;
using System.Collections;

public class ToolTipController : MonoBehaviour {

    public GUISkin skin;

	private string instanceToolTip = "";
    private float cooldownTime = 0f;
    private bool cooldownIsRunning = false;

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
            }
        }
	}

    void OnGUI()
    {
        GUI.skin = skin;
        GUI.Label(new Rect(20, 20, Screen.width, 100), instanceToolTip);
    }

	public void setToolTip(string toolTip) {
		instanceToolTip = toolTip;
        cooldownTime = 1.2f;
        cooldownIsRunning = true;
	}
}
