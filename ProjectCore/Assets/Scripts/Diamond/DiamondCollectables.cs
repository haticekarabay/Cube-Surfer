using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondCollectables : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(13, 45, 45) * Time.deltaTime * 3);
    }
}
