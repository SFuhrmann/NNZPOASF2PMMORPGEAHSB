using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public GameObject ninjaProgramm;

	public bool drunkCoffee = false;
    public bool tastedBananaSausage = false;
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
    public _ObjLaptopScreenController screen;

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
            screen.fadeTimer = screen.fadeTime;
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
	        ToolTipController.instance.setToolTip("Zombievirus geheilt.", false);
		}
	}

	public void setDeletedDesktopNinjaDone(GameObject ninja) {
		if (unhideDesktopNinja && !deletedDesktopNinja) {
            getNinja = true;
			deletedDesktopNinja = true;
            Destroy(ninja);
			checklist.checkListItem(ChecklistController.NINJA_QUEST);
            ToolTipController.instance.setToolTip("Ninja überlistet.", false);
		} else {

		}
	}

	public void setUnhideDesktopNinjaDone() {
        if (!unhideDesktopNinja)
        {
            unhideDesktopNinja = true;
            ninjaProgramm.SetActive(true);
            ToolTipController.instance.setToolTip("Oh ein Ninja");
        }
	}

	public void setTrashedPencilDone(GameObject pen) {

        if (paintedGirlfriendPhoto && !trashedPencil)
        {
            Destroy(pen);
            killNazi = true;
            checklist.checkListItem(ChecklistController.NAZI_QUEST);
            trashedPencil = true;
            ToolTipController.instance.setToolTip("Nazi getötet.", false);
        }
        else
        {
            ToolTipController.instance.setToolTip("Den brauche ich noch");
        }
	}

	public void setEatenChocolateBarDone() {
        if (eatenChocolateBar) return;
		eatenChocolateBar = true;
        checklist.checkListItem(ChecklistController.PIRATE_QUEST);
        findStash = true;
        ToolTipController.instance.setToolTip("Schatz gefunden. Lecker.", false);
	}

	public void setOpenedLunchPackDone() {
        if (!openedLunchPack) ;
		openedLunchPack = true;
	}

    public void setPaintedGirlfriendPhotoDone()
    {
		if (!paintedGirlfriendPhoto) 
		{
	        paintedGirlfriendPhoto = true;
	        checklist.checkListItem(ChecklistController.GIRLFRIEND_QUEST);
	        lookAtBreasts = true;
	        ToolTipController.instance.setToolTip("Am Flittchen ergötzt.", false);
		}
	}

	public void setSentMailDone() {
		sentMail = true;
	}

	public bool setTrashedOrcDone() {
        if (cleanedCoffeeStain && !trashedOrc)
        {
            ToolTipController.instance.setToolTip("Den Ork beseitigt.", false);
            trashedOrc = true;
            checklist.checkListItem(ChecklistController.ORC_QUEST);
            huntOrc = true;
            return true;
        }
        else
            ToolTipController.instance.setToolTip("Das ist zu trocken um den Popel vom Tisch zu kratzen");
        return false;
	}

    public void setTastedBananaSausageDone(GameObject bananaSausage)
    {
        if (!tastedBananaSausage)
        {
            tastedBananaSausage = true;
            bananaSausage.GetComponent<BananaSausage>().startPosition = new Vector3(-1.752821f, -4.479155f, -10.33814f);
            ToolTipController.instance.setToolTip("Uäh schon wieder Bananen-Wurst-Brot");
        }
    }

	public void setAttackedColleagueDone() {
		attackedColleague = true;
        
	}

	public void setAnsweredPhoneCallDone() {
        if (answeredPhoneCall) return;
		answeredPhoneCall = true;
        contactAlien = true;
        checklist.checkListItem(ChecklistController.ALIEN_QUEST);
		ToolTipController.instance.setToolTip("Nach Hause telefoniert.", false);
	}

	public void setFixedBugDone() {
        if (!fixedBug)
		    fixedBug = true;
	}

    public void setOpenedBreadPackDone()
    {
        if (!openedBreadPack)
            openedBreadPack = true;
    }

    public void setCleanedCoffeeStainDone()
    {
        if (cleanedCoffeeStain) return;
        cleanedCoffeeStain = true;
        ToolTipController.instance.setToolTip("Jetzt ist es mit Kaffee vollgesogen");
    }

    public void setDuelStarted()
    {
        if (duelStarted) return;
        duelStarted = true;
        duelResetTimer = duelResetTime;
		ToolTipController.instance.setToolTip("Er wirft nach mir - Ich muss mich wehren");
    }

    public bool setThrownPaperDone()
    {
        if (duelStarted && drunkCoffee && trashedOrc && !thrownPaper)
        {
			ToolTipController.instance.setToolTip("Nimm das!");
            thrownPaper = true;
			if (thrownBananaSausage)
			{
				winPvp = true;
				checklist.checkListItem(ChecklistController.PVP_QUEST);
                ToolTipController.instance.setToolTip("Erstes PvP gewonnen", false);
			}
            
            return true;
        }
		ToolTipController.instance.setToolTip("Ich muss ihn erst heraus fordern");

        return false;
    }

    public bool setThrownBananaSausageDone()
    {
        if (duelStarted && !thrownBananaSausage)
        {
			ToolTipController.instance.setToolTip("Fang!");
            thrownBananaSausage = true;
			if (thrownPaper)
			{
            	winPvp = true;
            	checklist.checkListItem(ChecklistController.PVP_QUEST);
                ToolTipController.instance.setToolTip("Erstes PvP gewonnen", false);
			}
            return true;
        }
		ToolTipController.instance.setToolTip("Ich muss ihn erst heraus fordern");
        return false;
    }

    void Win()
    {
		ToolTipController.instance.setToolTip("Haha, ich kann alles", false);
        Invoke("winwin", 3);
    }

    void winwin()
    {
        Destroy(GameObject.Find("WimpyLoop"));
        Destroy(GameObject.Find("MusicLoop"));
        Application.LoadLevel(0);
    }
}
