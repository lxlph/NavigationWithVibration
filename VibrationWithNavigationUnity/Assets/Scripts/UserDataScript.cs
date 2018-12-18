using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDataScript : MonoBehaviour
{
    public int correctTurns;
    public int wrongTurns;
    [Tooltip("Select Vibration Method: \n" +
        "1 - One-Handed \n" +
        "2 - Two-Handed"
    )]
    public int vibrationMethod = 1;

    public void addCorrectTurn()
    {
        correctTurns++;
    }

    public void addWrongTurn()
    {
        wrongTurns++;
    }

    public int getVibrationMethod()
    {
        return vibrationMethod;
    }
}
