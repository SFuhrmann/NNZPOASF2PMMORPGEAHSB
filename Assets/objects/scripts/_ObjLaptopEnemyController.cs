using UnityEngine;
using System.Collections;

public class _ObjLaptopEnemyController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnMouseDown()
    {
        print("laptop enemy");
        GameManager.instance.setDuelStarted();
    }
}
