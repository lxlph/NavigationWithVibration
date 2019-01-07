using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDataScript : MonoBehaviour
{
    [Tooltip("Select Vibration Method: \n" +
        "1 - One-Handed \n" +
        "2 - Two-Handed"
    )]
    public int vibrationMethod = 1;
    public GameObject wrongTurnsNumberText;
    public GameObject correctTurnsNumberText;
    public GameObject displayTurnText;
    public GameObject finishplane;
    public GameObject sceneManager;
    public bool displayTurnActivated = true;
    private bool sceneFinished = false;
    private int wrongTurns;
    private int correctTurns;    

    public void Start()
    {
        sceneManager = GameObject.Find("SceneManager");
        sceneManager.GetComponent<SceneManagerWriteCSV>().ResetData(gameObject);
    }
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
        sceneManager.GetComponent<SceneManagerWriteCSV>().GetData(gameObject);
        finishplane.SetActive(true);
        sceneFinished = true;
    }

    public void Update()
    {
        if (Input.GetKeyDown("space") && sceneFinished)
        {
            sceneManager.GetComponent<SceneManagerScript>().NextScene();
        }
    }

    public int getWrongTurns()
    {
        return wrongTurns;
    }

    public int getCorrectTurns()
    {
        return correctTurns;
    }

    public void resetWrongTurns()
    {
        wrongTurns = 0;
    }

    public void resetCorrectTurns()
    {
        correctTurns = 0;
    }
}
