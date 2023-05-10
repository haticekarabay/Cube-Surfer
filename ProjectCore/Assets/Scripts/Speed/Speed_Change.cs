using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Speed_Change: MonoBehaviour
{
    public Slider speedSlider; // SpeedSlider  referans
    [SerializeField] private PlayerForwardMotion _collector;

    void Start()
    {
       
        speedSlider.onValueChanged.AddListener(ChangeSpeed); // Slider function
    }

    public void ChangeSpeed(float value)
    {
        _collector.velocityOfPlayer += (value/10);
    }
    
}