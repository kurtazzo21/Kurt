using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrisonBreak : MonoBehaviour {

    public Text myText;

    void cell()
    {
        myText.text = "You are in a prison cell, and you want to escape.There are " +
                       "some dirty sheets on the bed, a mirror on the wall, and the door " +
                       " is locked from the outside.\n\n" +
                       "Press S to view Sheets, M to view Mirror and L to view Lock";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = states.sheets_0;
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            myStates = states.mirror;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = states.lock_0;
        }
    }

    void sheets_0()
    {
        myText.text = "You can't believe you sleep in these things. Surely it's " + 
                      "time somebody changed them. The pleasures of prison life " +
                      "I guess!\n\n" + 
                      "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = states.cell;
        }
    }

    void mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
                      "some dirty sheets on the bed, a mirror , " +
                      "and that pesky door is still there, and firmly locked!\n\n" +
                      "Press R to go back Cell or T to Take the Mirror";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = states.cell;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            myStates = states.cell_mirror;
        }
    }

    void lock_0()
    {
        myText.text = "This is one of those button locks. You have no idea what the " +
                      "combination is. You wish you could somehow see where the dirty " +
                      "fingerprints were, maybe that would help.\n\n" +
                      "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = states.cell;
        }
    }

    void cell_mirror()
    {
        myText.text = "You are still in your cell, and you STILL want to escape! There are " +
                      "some dirty sheets on the bed, a mark where the mirror was, " +
                      "and that pesky door is still there, and firmly locked!\n\n" +
                      "Press S to view Sheets, or L to view Lock";
        if(Input.GetKeyDown(KeyCode.S))
        {
            myStates = states.sheets_1;
        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            myStates = states.lock_1;
        }
    }

    void sheets_1()
    {
        myText.text = "Holding a mirror in your hand doesn't make the sheets look " +
		              "any better.\n\n" +
                      "Press R to Return to roaming your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = states.cell_mirror;
        }
    }

    void lock_1()
    {
        myText.text = "You carefully put the mirror through the bars, and turn it round " +
                      "so you can see the lock. You can just make out fingerprints around " +
                      "the buttons. You press the dirty buttons, and hear a click.\n\n" +
                      "Press O to Open, or R to Return to your cell";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = states.cell_mirror;
        }
        else if (Input.GetKeyDown(KeyCode.O))
        {
            myStates = states.corridor_0;
        }
    }

    void corridor_0()
    {
        myText.text = "You enter the corridor.\n\n" +
                      "Press S to go to stairs, F to look at floor, C to go to closet door";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = states.stairs_0;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            myStates = states.floor;
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            myStates = states.closet_door;
        }
    }

    void stairs_0()
    {
        myText.text = "You start walking up the stairs towards the outside light. " +
                      "You realise it's not break time, and you'll be caught immediately. " +
                      "You slither back down the stairs and reconsider.\n\n" +
                      "Press R to Return to the corridor";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = states.corridor_0;
        }
    }

    void floor()
    {
        myText.text = "Rummaging around on the dirty floor, you find a hairclip.\n\n" +
                      "Press H to use the hairclip, R to Return to the corridor";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = states.corridor_0;
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            myStates = states.corridor_1;
        }
    }

    void closet_door()
    {
        myText.text = "You are looking at a closet door, unfortunately it's locked. " +
                      "Maybe you could find something around to help enourage it open?\n\n" +
                      "Press R to Return to the corridor";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = states.corridor_0;
        }
    }

    void corridor_1()
    {
        myText.text = "Still in the corridor. Floor still dirty. Hairclip in hand. " +
                      "Now what? You wonder if that lock on the closet would succumb to " +
                      "to some lock-picking?\n\n" +
                      "Press S to go to stairs, P to go in the closet";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = states.stairs_1;
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            myStates = states.in_closet;
        }
    }

    void stairs_1()
    {
        myText.text = "Unfortunately wielding a puny hairclip hasn't given you the " +
                      "confidence to walk out into a courtyard surrounded by armed guards!\n\n" +
                      "Press R to Return to the corridor";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = states.corridor_1;
        }
    }

    void in_closet()
    {
        myText.text = "Inside the closet you see a cleaner's uniform that looks about your size! " +
                      "Seems like your day is looking-up.\n\n" +
                      "Press D to dress differently, R to return to corridor";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myStates = states.corridor_1;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            myStates = states.corridor_3;
        }
    }

    void corridor_3()
    {
        myText.text = "You're standing back in the corridor, now convincingly dressed as a cleaner.   " +
                      "You strongly consider the run for freedom.\n\n" +
                      "Press S to use the stairs, U to undress";
        if (Input.GetKeyDown(KeyCode.S))
        {
            myStates = states.courtyard;
        }
       else if (Input.GetKeyDown(KeyCode.U))
        {
            myStates = states.in_closet;
        }
    }

    void courtyard()
    {
        myText.text = "You walk through the courtyard dressed as a cleaner. " +
                      "The guard tips his hat at you as you waltz past, claiming " +
                      "your freedom. You heart races as you walk into the sunset.\n\n" +
                      "Press P to Play again.";
        if (Input.GetKeyDown(KeyCode.P))
        {
            myStates = states.cell;
        }
    }

    private enum states
    {
        cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0, stairs_0, floor, closet_door, stairs_1, corridor_1, in_closet, corridor_3, courtyard
    };

    private states myStates;
            
	// Use this for initialization
	void Start () {

        myStates = states.cell;
	}
	
	// Update is called once per frame
	void Update () {

        print(myStates);
        if (myStates == states.cell)
        {
            cell();
        }
        else if (myStates == states.sheets_0)
        {
            sheets_0();
        }
        else if (myStates == states.mirror)
        {
            mirror();
        }
        else if (myStates == states.lock_0)
        {
            lock_0();
        }
        else if (myStates == states.cell_mirror)
        {
            cell_mirror();
        }
        else if (myStates == states.sheets_1)
        {
            sheets_1();
        }
        else if (myStates == states.lock_1)
        {
            lock_1();
        }
        else if (myStates == states.corridor_0)
        {
            corridor_0();
        }
        else if (myStates == states.stairs_0)
        {
            stairs_0();
        }
        else if (myStates == states.floor)
        {
            floor();
        }
        else if (myStates == states.closet_door)
        {
            closet_door();
        }
        else if (myStates == states.corridor_1)
        {
            corridor_1();
        }
        else if (myStates == states.stairs_1)
        {
            stairs_1();
        }
        else if (myStates == states.in_closet)
        {
            in_closet();
        }
        else if (myStates == states.corridor_3)
        {
            corridor_3();
        }
        else if (myStates == states.courtyard)
        {
            courtyard();
        }
    }
}
