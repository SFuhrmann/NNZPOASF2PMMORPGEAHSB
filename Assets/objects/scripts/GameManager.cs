using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private bool givenCoffee = false;
	private bool deletedDesktopNinja = false;
	private bool unhideDesktopNinja = false;
	private bool trashedPencil = false;
	private bool eatenChocolateBar = false;
	private bool openedLunchPack = false;
	private bool trashedGirlfriendPhoto = false;
	private bool sentMail = false;
	private bool trashedOrc = false;
	private bool attackedColleague = false;
	private bool answeredPhoneCall = false;
	private bool fixedBug = false;

	internal static GameManager instance;

	public ChecklistController checklist;

	void Start () {
		instance = this;
	}

	public void setGivenCoffeeDone() {
		givenCoffee = true;
	}

	public void setDeletedDesktopNinjaDone() {
		if (unhideDesktopNinja) {
			deletedDesktopNinja = true;
			//TODO: checklist.checkDas
		} else {
			Debug.Log ("You have to unhide the desktop ninja first");
		}
	}

	public void setUnhideDesktopNinjaDone() {
		unhideDesktopNinja = true;
	}

	public void setTrashedPencilDone() {
		trashedPencil = true;
	}

	public void setEatenChocolateBarDone() {
		eatenChocolateBar = true;
	}

	public void setOpenedLunchPackDone() {
		openedLunchPack = true;
	}

	public void setTrashedGirlfriendPhotoDone() {
		trashedGirlfriendPhoto = true;
	}

	public void setSentMailDone() {
		sentMail = true;
	}

	public void setTrashedOrcDone() {
		trashedOrc = true;
	}

	public void setAttackedColleagueDone() {
		attackedColleague = true;
	}

	public void setAnsweredPhoneCallDone() {
		answeredPhoneCall = true;
	}

	public void setFixedBugDone() {
		fixedBug = true;
	}

}
