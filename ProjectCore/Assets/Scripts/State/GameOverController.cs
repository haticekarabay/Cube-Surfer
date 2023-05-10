using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
   
    [SerializeField] private GameObject restartButton;
    
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void SetMainCubeDead()
    {
        restartButton.SetActive(true);
        Time.timeScale = 0;
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(0);

    }
}