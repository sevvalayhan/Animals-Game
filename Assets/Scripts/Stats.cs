using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public static int lives = 3;
    public static int score = 0;

    void Start()
    {
        Debug.Log("Lives: " + lives + " Score: " + score);
    }


    
}
