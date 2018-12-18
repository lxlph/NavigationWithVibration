using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDataScript : MonoBehaviour
{
    public int wrongTurns;
    public int correctTurns;    
    public GameObject wrongTurnsNumberText;
    public GameObject correctTurnsNumberText;
    [Tooltip("Select Vibration Method: \n" +
        "1 - One-Handed \n" +
        "2 - Two-Handed"
    )]
    public int vibrationMethod = 1;

    public void addWrongTurn()
    {
        wrongTurns++;
        wrongTurnsNumberText.GetComponent<UnityEngine.UI.Text>().text = wrongTurns.ToString();
    }

    public void addCorrectTurn()
    {
        correctTurns++;
        correctTurnsNumberText.GetComponent<UnityEngine.UI.Text>().text = correctTurns.ToString();
    }

    public int getVibrationMethod()
    {
        return vibrationMethod;
    }
}
