using UnityEngine;
using System.Collections;

public class ObjController : MonoBehaviour {

    protected Vector3 mouseDownPosition;
    public string toolTipMessage;
    protected float deadSpace = 0.19f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        mouseDownPosition = Input.mousePosition;
    }

    void OnMouseUp()
    {
        Vector3 newMousePosition = Input.mousePosition;
        if (newMousePosition.y - deadSpace > mouseDownPosition.y)
        {
            OnSwipeUp();
        }
        else if (newMousePosition.y + deadSpace < mouseDownPosition.y)
        {
            OnSwipeDown();
        }
        else if (newMousePosition.x - deadSpace > mouseDownPosition.x)
        {
            OnSwipeRight();
        }
        else if (newMousePosition.x + deadSpace < mouseDownPosition.x)
        {
            OnSwipeLeft();
        }
        else
        {
            OnClicked();
        }

    }

    protected virtual void OnSwipeUp() { }
    protected virtual void OnSwipeRight() { }
    protected virtual void OnSwipeDown() { }
    protected virtual void OnSwipeLeft() { }
    protected virtual void OnClicked() { }
}
