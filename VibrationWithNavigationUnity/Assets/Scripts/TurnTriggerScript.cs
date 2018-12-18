using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTriggerScript : MonoBehaviour
{
    public string targetName;
    private GameObject userGameObject;
    private string lastTouchedGameobject = "";
    private bool triggerAlreadyPassed;

    public void Start()
    {
        userGameObject = GameObject.Find("User");
        //set vibration method 
        int vibrationMethodNumber = userGameObject.GetComponent<UserDataScript>().getVibrationMethod();
        gameObject.GetComponent<TurnTriggerToArduinoScript>().setVibrationMethod(vibrationMethodNumber);
    }

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
            userGameObject.GetComponent<UserDataScript>().setDisplayTurnText("");
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
        string logText = "";
        if (goName == "SCollider")
        {
            logText = ("Turn Right");
            gameObject.GetComponent<TurnTriggerToArduinoScript>().vibrateRight();
        }
        else if (goName == "WCollider")
        {
            logText = ("Turn Left");
            gameObject.GetComponent<TurnTriggerToArduinoScript>().vibrateLeft();
        }
        else if (goName == "ACollider")
        {
            logText = ("Straight Forward");
        }
        else if (goName == "DCollider (Target)")
        {
            logText = ("TargetStart");
        }
        //Debug.Log(logText);
        userGameObject.GetComponent<UserDataScript>().setDisplayTurnText(logText);
    }

}
