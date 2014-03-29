using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject ninjaProgramm;

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

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Camera.main.GetComponent<CameraScript>().zoomingIN = true;
        }
    }

    void CheckAllBools()
    {
        if (healZombie && killNazi && findStash && huntOrc && getNinja /*&& contactAlien*/ && winPvp && lookAtBreasts)
            Win();
    }


	public void setDrunkCoffeeDone() {
		drunkCoffee = true;
        healZombie = true;
        checklist.checkListItem(ChecklistController.ZOMBIE_QUEST);
        ToolTipController.instance.setToolTip("WACH!!!");
	}

	public void setDeletedDesktopNinjaDone(GameObject ninja) {
		if (unhideDesktopNinja) {
            getNinja = true;
			deletedDesktopNinja = true;
            Destroy(ninja);
			checklist.checkListItem(ChecklistController.NINJA_QUEST);
            ToolTipController.instance.setToolTip("Weg ist er");
		} else {

		}
	}

	public void setUnhideDesktopNinjaDone() {
        if (!unhideDesktopNinja)
        {
            unhideDesktopNinja = true;
            ToolTipController.instance.setToolTip("Oh ein Ninja");
            ninjaProgramm.SetActive(true);
        }
	}

	public void setTrashedPencilDone(GameObject pen) {

        if (paintedGirlfriendPhoto)
        {
            Destroy(pen);
            killNazi = true;
            checklist.checkListItem(ChecklistController.NAZI_QUEST);
            trashedPencil = true;
            ToolTipController.instance.setToolTip("Weg damit");
        }
        else
        {
            ToolTipController.instance.setToolTip("Den brauche ich noch");
        }
	}

	public void setEatenChocolateBarDone() {
		eatenChocolateBar = true;
        checklist.checkListItem(ChecklistController.PIRATE_QUEST);
        findStash = true;
        ToolTipController.instance.setToolTip("Das war lecker");
	}

	public void setOpenedLunchPackDone() {
		openedLunchPack = true;
	}

    public void setPaintedGirlfriendPhotoDone()
    {
        paintedGirlfriendPhoto = true;
        checklist.checkListItem(ChecklistController.GIRLFRIEND_QUEST);
        lookAtBreasts = true;
        ToolTipController.instance.setToolTip("So ist es schöner");
	}

	public void setSentMailDone() {
		sentMail = true;
	}

	public bool setTrashedOrcDone() {
        if (cleanedCoffeeStain)
        {
            ToolTipController.instance.setToolTip("Ihh Popel mit Kaffeematsch");
            trashedOrc = true;
            checklist.checkListItem(ChecklistController.ORC_QUEST);
            huntOrc = true;
            return true;
        }
        else
            ToolTipController.instance.setToolTip("Das ist zu trocken um den Popel vom Tisch zu kratzen");
        return false;
	}

	public void setAttackedColleagueDone() {
		attackedColleague = true;
        ToolTipController.instance.setToolTip("Er wirft nach mir - Ich brauche Waffen");
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
        ToolTipController.instance.setToolTip("Uäh schon wieder Bananen-Wurst-Brot");
    }

    public void setCleanedCoffeeStainDone()
    {
        cleanedCoffeeStain = true;
        ToolTipController.instance.setToolTip("Jetzt ist es mit Kaffee vollgesogen");
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
            checklist.checkListItem(ChecklistController.PVP_QUEST);
            return true;
        }
        return false;
    }

    void Win()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}
