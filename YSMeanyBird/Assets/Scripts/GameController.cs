﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("Game Over Ui Object for displaying Game Over Screen")]
    public GameObject gameOverCanvas;
    [Header("score UI Object for displaying Score")]
    public GameObject scoreCanvas;
    [Header("spawner Object for spawningofjects in game")]
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        scoreCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        spawner.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        spawner.SetActive(false);
        Time.timeScale = 0;
    }
}
