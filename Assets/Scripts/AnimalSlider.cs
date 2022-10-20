using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalSlider : MonoBehaviour
{

    public Slider slider;

    public void SetHunger(int value)
    {
        if (slider.value < 2)
        {
            slider.value += value;

        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        slider.value = 0;
        slider.maxValue = 3;

    }


    void Update()
    {

    }
}
