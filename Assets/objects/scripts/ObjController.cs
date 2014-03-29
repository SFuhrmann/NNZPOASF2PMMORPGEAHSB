using UnityEngine;
using System.Collections;

public class ObjController : MonoBehaviour {

    public string toolTipMessage;
    private bool dragging = false;
    private int screenHeight, screenWidth;
    private float cameraSizeY = 10;
    private float cameraSizeX = 18;
    private Vector3 startPosition;

	// Use this for initialization
	void Awake () {
        screenHeight = Screen.height;
        screenWidth = Screen.width;
        startPosition = transform.position;
	}
	
	// Update is called once per frame
	protected void Update () {
        if (dragging)
        {
            Vector3 mp = Input.mousePosition;

            print(screenHeight);
            print(screenWidth);

            //normalize mouse position to 0..1
            mp.y = mp.y / screenHeight * cameraSizeY - (cameraSizeY / 2);
            mp.x = mp.x / screenWidth * cameraSizeX - (cameraSizeX / 2);

            //set position
            transform.position = mp;
        }
	}

    void OnMouseDown()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        dragging = true;
    }

    void OnMouseUp()
    {
        GetComponent<BoxCollider2D>().enabled = true;
        dragging = false;
        ///Think about letting it there as it is or delete it away
        {
            OnClicked();
        }

        Invoke("resetPosition", 1);
    }

    //called when no swipe is detected
    void OnClicked() {
        //ToolTipController.instance.setToolTip(toolTipMessage);
    }

    void resetPosition()
    {
        print(GetComponent<BoxCollider2D>().enabled);
        transform.position = startPosition;
    }
}
