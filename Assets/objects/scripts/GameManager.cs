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
    private bool duelStarted = false;
    private bool thrownPaper = false;
    private bool thrownBananaSausage = false;
    private bool pvpWon = false;
    private float duelResetTimer;
    public float duelResetTime = 15;

	internal static GameManager instance;

	public ChecklistController checklist;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (duelResetTimer > 0)
        {
            duelResetTimer -= Time.deltaTime;
        }
        else
        {
            duelResetTimer = 0;
            duelStarted = false;
        }
    }

    void CheckAllBools()
    {
        if (drunkCoffee && deletedDesktopNinja && unhideDesktopNinja && trashedPencil && eatenChocolateBar &&
            openedLunchPack && paintedGirlfriendPhoto && trashedOrc && /*answeredPhoneCall && */ fixedBug && openedBreadPack &&
            cleanedCoffeeStain && duelStarted && thrownPaper && thrownBananaSausage && pvpWon)
            Win();
    }


	public void setDrunkCoffeeDone() {
		drunkCoffee = true;
        CheckAllBools();
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

    public void setDuelStarted()
    {
        duelStarted = true;
    }

    public void setThrownPaperDone()
    {
        if (duelStarted && drunkCoffee && trashedOrc)
            thrownPaper = true;
    }

    public void setThrownBananaSausageDone()
    {
        if (duelStarted && thrownPaper)
            thrownBananaSausage = true;
    }

    void Win()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
