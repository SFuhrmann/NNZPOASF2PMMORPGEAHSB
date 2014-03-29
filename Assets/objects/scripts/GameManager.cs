using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public bool drunkCoffee = false;
	public bool deletedDesktopNinja = false;
	public bool unhideDesktopNinja = false;
	public bool trashedPencil = false;
	public bool eatenChocolateBar = false;
	public bool openedLunchPack = false;
	public bool paintedGirlfriendPhoto = false;
	public bool sentMail = false;
	public bool trashedOrc = false;
	public bool attackedColleague = false;
	public bool answeredPhoneCall = false;
	public bool fixedBug = false;
    public bool openedBreadPack = false;
    public bool cleanedCoffeeStain = false;
    public bool duelStarted = false;
    public bool thrownPaper = false;
    public bool thrownBananaSausage = false;
    public bool pvpWon = false;
    public float duelResetTimer;
    public float duelResetTime = 15;

    public bool healZombie, killNazi, findStash, huntOrc, getNinja, contactAlien, winPvp, lookAtBreasts;

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
        CheckAllBools();
    }

    void CheckAllBools()
    {
        if (healZombie && killNazi && findStash && huntOrc && getNinja /*&& contactAlien*/ && winPvp && lookAtBreasts)
            Win();
    }


	public void setDrunkCoffeeDone() {
		drunkCoffee = true;
        healZombie = true;
	}

	public void setDeletedDesktopNinjaDone(GameObject ninja) {
		if (unhideDesktopNinja) {
            getNinja = true;
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
            killNazi = true;
            trashedPencil = true;
        }   
	}

	public void setEatenChocolateBarDone() {
		eatenChocolateBar = true;
        findStash = true;
	}

	public void setOpenedLunchPackDone() {
		openedLunchPack = true;
	}

    public void setPaintedGirlfriendPhotoDone()
    {
        paintedGirlfriendPhoto = true;
        lookAtBreasts = true;
	}

	public void setSentMailDone() {
		sentMail = true;
	}

	public bool setTrashedOrcDone() {
        if (cleanedCoffeeStain)
        {
            trashedOrc = true;
            huntOrc = true;
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
        duelResetTimer = duelResetTime;
    }

    public bool setThrownPaperDone()
    {
        if (duelStarted && drunkCoffee && trashedOrc)
        {
            thrownPaper = true;
            
            return true;
        }
        return false;
    }

    public bool setThrownBananaSausageDone()
    {
        if (duelStarted && thrownPaper)
        {
            thrownBananaSausage = true;
            winPvp = true;
            return true;
        }
        return false;
    }

    void Win()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
