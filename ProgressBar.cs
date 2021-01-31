using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    private Slider slider;
    private float targetProgress = 0;
    public float fillSpeed = 0.5f;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();

    }


   void Update()
    {
        slider.value = PlayerJourney.percentage;
    }

}
