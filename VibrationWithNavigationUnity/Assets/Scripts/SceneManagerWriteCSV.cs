using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class SceneManagerWriteCSV : MonoBehaviour
{
    public InputField InputField;
    public string timerText;
    public int wrongTurns;
    public int correctTurns;
    public string sceneName;
    private char lineSeperater = '\n';
    private char fieldSeperator = ',';

    public void GetData(GameObject userDataGo)
    {
        string userId = InputField.text;
        string mapName = sceneName.Substring(0, 4);
        string routeName = sceneName.Substring(4, 2);
        string methodName = sceneName.Substring(7, 5);
        timerText = gameObject.GetComponent<SceneManagerTimeMeasurement>().GetTimerText();
        wrongTurns = userDataGo.GetComponent<UserDataScript>().getWrongTurns();
        correctTurns = userDataGo.GetComponent<UserDataScript>().getCorrectTurns();
        
        File.AppendAllText(getPath(), lineSeperater 
            + userId + fieldSeperator
            + mapName + fieldSeperator
            + routeName + fieldSeperator
            + methodName + fieldSeperator
            + timerText + fieldSeperator 
            + wrongTurns + fieldSeperator 
            + correctTurns);
        
    }

    public void ResetData(GameObject userDataGo)
    {
        gameObject.GetComponent<SceneManagerTimeMeasurement>().ResetTimerText();
        timerText = gameObject.GetComponent<SceneManagerTimeMeasurement>().GetTimerText();
        userDataGo.GetComponent<UserDataScript>().resetWrongTurns();
        wrongTurns = userDataGo.GetComponent<UserDataScript>().getWrongTurns();
        userDataGo.GetComponent<UserDataScript>().resetCorrectTurns();
        correctTurns = userDataGo.GetComponent<UserDataScript>().getCorrectTurns();
    }

    public void setSceneName(string name)
    {
        sceneName = name;
    }

    
    private string getPath()
    {
    #if UNITY_EDITOR
            return Application.dataPath + "/SavedData.csv";
    #elif UNITY_ANDROID
            return Application.persistentDataPath+"Saved_data.csv";
    #elif UNITY_IPHONE
            return Application.persistentDataPath+"/"+"Saved_data.csv";
    #else
            return Application.dataPath +"/"+"Saved_data.csv";
    #endif
    }

    void OnGUI()
    {
        if (InputField.isFocused && InputField.text != "" && Input.GetKey(KeyCode.Return))
        {
            gameObject.GetComponent<SceneManagerScript>().startSimulation();
        }
    }

}
