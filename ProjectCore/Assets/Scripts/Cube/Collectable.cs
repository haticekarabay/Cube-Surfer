using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public bool isCollected;
    public int heightIndex;

    [SerializeField] private Collector _collector;
    [SerializeField] private PlayerForwardMotion mainBlock;

    void Start()
    {
        isCollected = false;
        _collector = FindObjectOfType<Collector>();
        mainBlock = FindObjectOfType<PlayerForwardMotion>();
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("OtherCubes"))
        {
        
            TouchObstacle();
            mainBlock.transform.DOJump(new Vector3(mainBlock.transform.position.x, mainBlock.transform.position.y,
            mainBlock.transform.position.z + 2f), 1f, 1, .3f);
           
        }
        
    }

    public void TouchObstacle()
    {
        _collector.height--;
        _collector.allCubes.RemoveAt(_collector.index);
        transform.parent = null;
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }
    private IEnumerator CubeDestroyTimer()
    {   
        yield return new WaitForSeconds(.08f);
        _collector.height--;
        Destroy(_collector.allCubes[_collector.index]);
    }

}