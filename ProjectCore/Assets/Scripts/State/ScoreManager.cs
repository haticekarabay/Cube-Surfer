using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;

    public TextMeshProUGUI txtScore;


    #region Singleton
    public static ScoreManager Instance;
    void Singleton()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    #endregion

    private void Awake()
    {
        Singleton();
    }

    public void IncrreaseScore()
    {
        score++;
        txtScore.text = $"Score: {score}";
    }

}
