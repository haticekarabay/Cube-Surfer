using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveInputSystem : MonoBehaviour
{
    private float _lastFrameFingerPositionX;
    private float _moveFactoryX;

    public float MoveFactoryX { get => _moveFactoryX; set => _moveFactoryX = value; }


    void Update()
    {
       // if (!GameManager.instance.IsSessionPlaying)
        //    return;


        if (Input.GetMouseButton(0))
        {
            // Debug.Log("GetMouseButton");
            Vector3 currentMousePosition = Input.mousePosition;
            _moveFactoryX = currentMousePosition.x - _lastFrameFingerPositionX;
            _lastFrameFingerPositionX = Input.mousePosition.x;


        }

        if (Input.GetMouseButtonDown(0))
        {
            _lastFrameFingerPositionX = Input.mousePosition.x;


            Debug.Log($"GetMouseButtoDown {_moveFactoryX}");
        }

        if (Input.GetMouseButtonUp(0))
        {
            // Debug.Log("GetMouseButtonUp");
            _moveFactoryX = 0;
        }
    }
}
