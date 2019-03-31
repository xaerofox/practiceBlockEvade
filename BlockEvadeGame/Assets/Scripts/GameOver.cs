﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
    public GameObject gameOverScreen;
    public Text survivedText;
    public Text secondsSurvived;
    bool isGameOver;

	// Use this for initialization
	void Start () {
        FindObjectOfType<PlayerController>().OnPlayerDeath += OnGameOver;
	}
	
	// Update is called once per frame
	void Update () {
        if (isGameOver)
        {
            if (Input.GetKeyDown(KeyCode.Space))
                SceneManager.LoadScene(0);
        }
    }

    void OnGameOver()
    {
        gameOverScreen.SetActive(true);
        secondsSurvived.text = Mathf.RoundToInt(Time.timeSinceLevelLoad).ToString() + "s";
        isGameOver = true;
    }
}
