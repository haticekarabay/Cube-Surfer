using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] private GameObject mainBlock;
    [SerializeField] private GameObject player_cat;

    // For UI
    [SerializeField] private GameObject restartButton;
    [SerializeField] private GameObject levelButton;
    [SerializeField] private GameObject win_text;
    [SerializeField] private GameObject game_over_image;


    public List<GameObject> allCubes;
    public int height, index;

   

    void Start()
    {
        mainBlock = GameObject.FindGameObjectWithTag("MainBlock");
        player_cat= GameObject.FindGameObjectWithTag("cat");
        
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable") && other.gameObject.GetComponent<Collectable>().isCollected == false)
        {
            height += 1;
            allCubes.Add(other.gameObject);
            other.gameObject.GetComponent<Collectable>().isCollected = true;
            other.gameObject.SetActive(false);
            mainBlock.transform.localScale += new Vector3(0, 1f, 0);
            player_cat.transform.localPosition += new Vector3(0, 0.005f, 0);
            index++;
        }


        else if (other.CompareTag("OtherCubes") && other.gameObject.GetComponent<Collectable>().isCollected == false )
        {
            height -= 1;
            allCubes.Add(other.gameObject);
            
            other.gameObject.GetComponent<Collectable>().isCollected = true;
            if ((index - 1) != 0)
            {
                mainBlock.transform.localScale -= new Vector3(0, 1f, 0);
                player_cat.transform.localPosition -= new Vector3(0, 0.005f, 0);
            }
            index--;
        }

        // game over
        if (index == 0)
        {
            Time.timeScale = 0;
            restartButton.SetActive(true);
            game_over_image.SetActive(true);
           
        }

        //finalzone
        if (other.CompareTag("FinalZone"))
        {
            
            Time.timeScale = 0;
            levelButton.SetActive(true);
            win_text.SetActive(true);
            
        }
        

    }
}
