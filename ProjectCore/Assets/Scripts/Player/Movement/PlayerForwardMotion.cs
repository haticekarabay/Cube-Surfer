using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForwardMotion : MonoBehaviour
{
    public float leftBound;
    public float rightBound;

    public Rigidbody rgb;
    public float speed;


    [SerializeField]
    public float velocityOfPlayer;

    private void FixedUpdate()
    {
        transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime * velocityOfPlayer;


        if (transform.position.x > leftBound)
        {
            transform.position = new Vector3(leftBound, transform.position.y, transform.position.z);

        }

        if (transform.position.x < rightBound)
        {
            transform.position = new Vector3(rightBound, transform.position.y, transform.position.z);
        }

    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        // for diamonds
        if (other.gameObject.tag == "Diamond")
        {
            other.gameObject.SetActive(false);

            ScoreManager.Instance.IncrreaseScore();
        }
        
    }

    
    

}
