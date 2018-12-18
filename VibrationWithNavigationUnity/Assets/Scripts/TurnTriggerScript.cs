using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnTriggerScript : MonoBehaviour
{
    public GameObject targetCollider;
    private string targetName;
    private GameObject userGameObject;
    private string lastTouchedGameobject = "";
    private bool triggerAlreadyPassed;
    public enum Direction { Left, Right, StraightForward}
    public Direction directionForTarget;

    public void Start()
    {
        targetName = targetCollider.name;
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
        else if (goName == targetName)
        {

            logText = getDirectionForTargetAction();
        }
        //Debug.Log(logText);
        userGameObject.GetComponent<UserDataScript>().setDisplayTurnText(logText);
    }

    public string getDirectionForTargetAction()
    {
        string logText = "";
        if(directionForTarget == Direction.Left)
        {
            logText = ("Turn Left");
            targetName = "SCollider";
            gameObject.GetComponent<TurnTriggerToArduinoScript>().vibrateLeft();
        }
        else if (directionForTarget == Direction.Right)
        {
            logText = ("Turn Right");
            targetName = "WCollider";
            gameObject.GetComponent<TurnTriggerToArduinoScript>().vibrateRight();
        }
        else
        {
            targetName = "ACollider";
            logText = ("Straight Forward");
        }
        return logText;
        
    }



}
