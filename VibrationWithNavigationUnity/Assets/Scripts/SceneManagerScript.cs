﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    private string[] arrRandSceneA = new string[]
    {"Map1S1_apple", "Map2S1_proto", "Map1S2_proto",  "Map2S2_apple",
    "Map1S1_proto","Map2S1_apple", "Map1S2_apple", "Map2S2_proto"};

    private string[] arrRandSceneB = new string[]
    {"Map1S1_proto","Map2S1_apple", "Map1S2_apple", "Map2S2_proto",
    "Map1S1_apple", "Map2S1_proto", "Map1S2_proto",  "Map2S2_apple"};

    public string[] arrChosenRandScene;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (Random.Range(0, 1) == 0)
        {
            arrChosenRandScene = arrRandSceneA;
        }
        else
        {
            arrChosenRandScene = arrRandSceneB;
        }
        SceneManager.LoadScene(arrChosenRandScene[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}