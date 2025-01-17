﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    /*
    private string[] arrRandSceneA = new string[]
    {"Map1S1_apple", "Map2S1_proto", "Map1S2_proto",  "Map2S2_apple",
    "Map1S1_proto","Map2S1_apple", "Map1S2_apple", "Map2S2_proto"};

    private string[] arrRandSceneB = new string[]
    {"Map1S1_proto","Map2S1_apple", "Map1S1_apple", "Map2S1_proto",
    "Map1S1_apple", "Map2S1_proto", "Map1S2_proto",  "Map2S2_apple"};
    */

    private string[] arrRandSceneA = new string[]
    {"Map1S1_apple", "Map2S1_proto", "Map1S1_proto",  "Map2S1_apple"};

    private string[] arrRandSceneB = new string[]
    {"Map1S1_proto","Map2S1_apple", "Map1S1_apple", "Map2S1_proto"};

    public string[] arrChosenRandScene;
    public int currentSceneIndex = 0;
    public bool VR_on;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (Random.Range(0, 2) == 0)
        {
            arrChosenRandScene = arrRandSceneA;
        }
        else
        {
            arrChosenRandScene = arrRandSceneB;
        }
        if (VR_on)
        {
            arrChosenRandScene = arrRandSceneA;
            startSimulation();
        }
    }

    public void startSimulation()
    {
        SceneManager.LoadScene(arrChosenRandScene[currentSceneIndex]);
        string sceneName = arrChosenRandScene[currentSceneIndex];
        gameObject.GetComponent<SceneManagerWriteCSV>().setSceneName(sceneName);
    }


    public void NextScene()
    {
        if(currentSceneIndex >= 6 || currentSceneIndex <= 1)
        {
            Debug.Log("Fragebogen ausfüllen!!!");
        }
        if (currentSceneIndex + 1 == arrChosenRandScene.Length)
        {
            Debug.Log("Quit sim");
            Application.Quit();
        }
        currentSceneIndex++;
        string sceneName = arrChosenRandScene[currentSceneIndex];
        SceneManager.LoadScene(sceneName);
        gameObject.GetComponent<SceneManagerWriteCSV>().setSceneName(sceneName);
    }
}
