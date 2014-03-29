using UnityEngine;
using System.Collections;

public class ObjController : MonoBehaviour {

    public string toolTipMessage;
    protected bool dragging, draggingReady;
    public bool draggable = true;
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

            //normalize mouse position to 0..1
            mp.y = mp.y / screenHeight * cameraSizeY - (cameraSizeY / 2);
            mp.x = mp.x / screenWidth * cameraSizeX - (cameraSizeX / 2);

            //set position
            transform.position = new Vector3(mp.x, mp.y, transform.position.z);
        }
	}

    void OnMouseDown()
    {
        if (draggable)
        {
            Vector3 newPos = transform.position;
            newPos.z = -5;
            transform.position = newPos;
            dragging = true;
        }
    }

    protected void OnMouseUp()
    {
        dragging = false;
        draggingReady = true;
        ///Think about letting it there as it is or delete it away
        {
            OnClicked();
        }

        Invoke("resetPosition", 0.02f);
    }

    //called when no swipe is detected
    void OnClicked() {
        //ToolTipController.instance.setToolTip(toolTipMessage);
    }

    void resetPosition()
    {
        draggingReady = false;
        transform.position = startPosition;
    }
}
