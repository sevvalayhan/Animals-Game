using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBands : MonoBehaviour
{
    public float topBound = 34;
    public float lowerBound = -15;
    public float xBound = 24;


  
    void Update()
    {
        if (transform.position.z<topBound)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z>lowerBound)
        {
            Destroy(gameObject);
            Stats.score--;
            Debug.Log("Score: " + Stats.score);
        }
        else if (transform.position.x<-xBound)
        {
            Destroy(gameObject);
            Stats.score--;
            Debug.Log("Score: " + Stats.score);
        }
        else if (transform.position.x>xBound)
        {
            Destroy(gameObject);
            Stats.score--;
            Debug.Log("Score: " + Stats.score);
        }
    }
}
