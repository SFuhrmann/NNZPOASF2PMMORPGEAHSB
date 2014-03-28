using UnityEngine;
using System.Collections;

public class ToolTipController : MonoBehaviour {

	private string instanceToolTip;
	internal static ToolTipController instance;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void setToolTip(string toolTip) {
		instance.instanceToolTip = toolTip;
	}
}
