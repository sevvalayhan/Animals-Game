using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public AnimalSlider animalSlider;
   
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       

        if (gameObject.CompareTag("Player"))
        {
                    
           
            Stats.lives--;
            Stats.score--;
            Debug.Log("Boom!" + Stats.lives + "Score: " + Stats.score);
          
            
        }
        else if (gameObject.CompareTag("Animal"))
        {
            animalSlider.SetHunger(1);

            Destroy(other.gameObject);
            Stats.score++;
            Debug.Log("Score: " + Stats.score);
        }
    }
}
