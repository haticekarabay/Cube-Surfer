using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private bool isGameOver = false;

    void Update()
    {
        if (isGameOver)
        {
            // Oyunu duraklat
            Time.timeScale = 0;
        }
    }

    public void GameOver()
    {
        isGameOver = true;
    }

    public void Restart()
    {
        // Oyunu devam ettir ve sahneyi yeniden yükle
        Time.timeScale = 1;
       // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

