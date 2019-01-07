//using System.IO;
using UnityEngine;

public class SceneManagerWriteCSV : MonoBehaviour
{
    public string timerText;
    public int wrongTurns;
    public int correctTurns;
    public string sceneName;
    private char lineSeperater = '\n';
    private char fieldSeperator = ',';

    public void GetData(GameObject userDataGo)
    {
        string mapName = sceneName.Substring(0, 2);
        string routeName = sceneName.Substring(2, 3);
        string methodName = sceneName.Substring(4, 9);
        timerText = gameObject.GetComponent<SceneManagerTimeMeasurement>().GetTimerText();
        wrongTurns = userDataGo.GetComponent<UserDataScript>().getWrongTurns();
        correctTurns = userDataGo.GetComponent<UserDataScript>().getCorrectTurns();
        //methodName
        Debug.Log("Write File");
        /*
        File.AppendAllText(getPath(), lineSeperater 
            + mapName + fieldSeperator
            + routeName + fieldSeperator
            + methodName + fieldSeperator
            + timerText + fieldSeperator 
            + wrongTurns + fieldSeperator 
            + correctTurns);
            */
        
    }

    public void ResetData(GameObject userDataGo)
    {
        Debug.Log("Reset Data");
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

    /*
    private string getPath()
    {
    #if UNITY_EDITOR
            return Application.dataPath + "/Assets/SavedData.csv";
    #elif UNITY_ANDROID
            return Application.persistentDataPath+"Saved_data.csv";
    #elif UNITY_IPHONE
            return Application.persistentDataPath+"/"+"Saved_data.csv";
    #else
            return Application.dataPath +"/"+"Saved_data.csv";
    #endif
    }
    */
}
