using UnityEngine;
using System.Collections;

public class ColliderStartController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown() {
		Debug.Log ("NEXT");
		Application.LoadLevel ("scene");
	}
}
