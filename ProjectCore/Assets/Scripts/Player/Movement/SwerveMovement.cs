using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovement : MonoBehaviour
{
[SerializeField]
    private SwerveInputSystem swerveInputSystem;

   
    void Update()
    {
        float swerveAmount = Time.deltaTime * 0.02f * swerveInputSystem.MoveFactoryX;
        swerveAmount = Mathf.Clamp(swerveAmount, -1f, 1f);
        transform.Translate(swerveAmount, 0f, 0f);
    }
}
