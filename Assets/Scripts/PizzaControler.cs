using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaControler : MonoBehaviour
{
    private float bound = 34;
    void Update()
    {
        if (transform.position.z>bound)
        {

            Destroy(gameObject);
        }
    }
}
