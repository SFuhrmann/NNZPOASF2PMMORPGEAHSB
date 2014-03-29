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
        if (healZombie && killNazi && findStash && huntOrc && getNinja && contactAlien && winPvp && lookAtBreasts)
            Win();
    }


	public void setDrunkCoffeeDone() {
		if (!drunkCoffee)
		{
			drunkCoffee = true;
	        healZombie = true;
	        checklist.checkListItem(ChecklistController.ZOMBIE_QUEST);
	        ToolTipController.instance.setToolTip("WACH!!!");
		}
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
        ToolTipController.instance.setToolTip("Lecker");
	}

	public void setOpenedLunchPackDone() {
		openedLunchPack = true;
	}

    public void setPaintedGirlfriendPhotoDone()
    {
		if (!paintedGirlfriendPhoto) 
		{
	        paintedGirlfriendPhoto = true;
	        checklist.checkListItem(ChecklistController.GIRLFRIEND_QUEST);
	        lookAtBreasts = true;
	        ToolTipController.instance.setToolTip("So ist es schöner");
		}
	}

	public void setSentMailDone() {
		sentMail = true;
	}

	public bool setTrashedOrcDone() {
        if (cleanedCoffeeStain)
        {
            ToolTipController.instance.setToolTip("Ihh - Popel mit Kaffeematsch");
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
        
	}

	public void setAnsweredPhoneCallDone() {
		answeredPhoneCall = true;
        contactAlien = true;
        checklist.checkListItem(ChecklistController.ALIEN_QUEST);
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
        ToolTipController.instance.setToolTip("Jetzt ist es mit Kaffee vollgesogen");
    }

    public void setDuelStarted()
    {
        duelStarted = true;
        duelResetTimer = duelResetTime;
		ToolTipController.instance.setToolTip("Er wirft nach mir - Ich muss mich wehren");
    }

    public bool setThrownPaperDone()
    {
        if (duelStarted && drunkCoffee && trashedOrc)
        {
			ToolTipController.instance.setToolTip("Nimm das!");
            thrownPaper = true;
			if (thrownBananaSausage)
			{
				winPvp = true;
				checklist.checkListItem(ChecklistController.PVP_QUEST);
			}
            
            return true;
        }
		ToolTipController.instance.setToolTip("Ich muss ihn erst heraus fordern");

        return false;
    }

    public bool setThrownBananaSausageDone()
    {
        if (duelStarted)
        {
			ToolTipController.instance.setToolTip("Fang!");
            thrownBananaSausage = true;
			if (thrownPaper)
			{
            	winPvp = true;
            	checklist.checkListItem(ChecklistController.PVP_QUEST);
			}
            return true;
        }
		ToolTipController.instance.setToolTip("Ich muss ihn erst heraus fordern");
        return false;
    }

    void Win()
    {
		ToolTipController.instance.setToolTip("Haha, ich kann alles");
        Application.LoadLevel(Application.loadedLevel);
    }
}
