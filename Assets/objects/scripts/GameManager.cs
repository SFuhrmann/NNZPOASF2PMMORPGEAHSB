using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private bool drunkCoffee = false;
	private bool deletedDesktopNinja = false;
	private bool unhideDesktopNinja = false;
	private bool trashedPencil = false;
	private bool eatenChocolateBar = false;
	private bool openedLunchPack = false;
	private bool paintedGirlfriendPhoto = false;
	private bool sentMail = false;
	private bool trashedOrc = false;
	private bool attackedColleague = false;
	private bool answeredPhoneCall = false;
	private bool fixedBug = false;
    private bool openedBreadPack = false;
    private bool cleanedCoffeeStain = false;

	internal static GameManager instance;

	public ChecklistController checklist;

	void Start () {
		instance = this;
	}

	public void setDrunkCoffeeDone() {
		drunkCoffee = true;
	}

	public void setDeletedDesktopNinjaDone(GameObject ninja) {
		if (unhideDesktopNinja) {
			deletedDesktopNinja = true;
            Destroy(ninja);
			checklist.checkListItem(ChecklistController.NINJA_QUEST);
		} else {
		}
	}

	public void setUnhideDesktopNinjaDone() {
		unhideDesktopNinja = true;
	}

	public void setTrashedPencilDone(GameObject pen) {
		
        if (paintedGirlfriendPhoto)
        {
            Destroy(pen);
            trashedPencil = true;
        }   
	}

	public void setEatenChocolateBarDone() {
		eatenChocolateBar = true;
	}

	public void setOpenedLunchPackDone() {
		openedLunchPack = true;
	}

    public void setPaintedGirlfriendPhotoDone()
    {
        paintedGirlfriendPhoto = true;
	}

	public void setSentMailDone() {
		sentMail = true;
	}

	public bool setTrashedOrcDone() {
        if (cleanedCoffeeStain)
        {
            trashedOrc = true;
            return true;
        }
        return false;
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

    public void setOpenedBreadPackDone()
    {
        openedBreadPack = true;
    }

    public void setCleanedCoffeeStainDone()
    {
        cleanedCoffeeStain = true;
    }
}
