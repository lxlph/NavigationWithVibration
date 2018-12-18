using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTriggerScript : MonoBehaviour
{
    public string targetName;
    public GameObject userGameObject;
    private string lastTouchedGameobject = "";
    private bool triggerAlreadyPassed;


    public void collideAction(string goCollided)
    {
        if (lastTouchedGameobject == "")
        {
            vibrateDirection(goCollided);
            setLastTouchedGameobject(goCollided);
        }
        else
        {
            checkTurn(goCollided);
            setLastTouchedGameobject("");
        }
    }

    public void setLastTouchedGameobject(string goName)
    {
        lastTouchedGameobject = goName;
    }

    public string getLastTouchedGameobject()
    {
        return lastTouchedGameobject;
    }

    public void checkTurn(string goName)
    {
        if (!triggerAlreadyPassed)
        {
            if (goName != targetName)
            {
                userGameObject.GetComponent<UserDataScript>().addWrongTurn();
            }
            else
            {
                userGameObject.GetComponent<UserDataScript>().addCorrectTurn();
            }
            triggerAlreadyPassed = true;
        }
    }

    public void vibrateDirection(string goName)
    {
        if (goName == "SCollider")
        {
            Debug.Log("Turn Right");
            gameObject.GetComponent<TurnTriggerToArduinoScript>().vibrateRight();
        }
        else if (goName == "WCollider")
        {
            Debug.Log("Turn Left");
            gameObject.GetComponent<TurnTriggerToArduinoScript>().vibrateLeft();
        }
        else if (goName == "ACollider")
        {
            Debug.Log("Straight Forward");
        }
        else if (goName == "DCollider (Target)")
        {
            Debug.Log("Wrong");
        }
    }

}
