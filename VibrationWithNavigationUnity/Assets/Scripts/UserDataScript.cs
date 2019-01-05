using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDataScript : MonoBehaviour
{
    public GameObject wrongTurnsNumberText;
    public GameObject correctTurnsNumberText;
    public GameObject displayTurnText;
    public GameObject finishplane;
    public bool displayTurnActivated = true;
    public GameObject sceneManager;

    [Tooltip("Select Vibration Method: \n" +
        "1 - One-Handed \n" +
        "2 - Two-Handed"
    )]
    public int vibrationMethod = 1;
    private int wrongTurns;
    private int correctTurns;    

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

    public void setDisplayTurnText(string text)
    {
        if (displayTurnActivated)
        {
            displayTurnText.GetComponent<UnityEngine.UI.Text>().text = text;
        }
    }

    public void showFinishMessage()
    {
        finishplane.SetActive(true);
    }
}
