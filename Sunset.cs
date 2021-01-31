using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Sunset : MonoBehaviour
{
    //SET Gradient and Sun light in Inspector:
    public Gradient sunTints;
    public SpriteRenderer sunset;

    public float speed = 0.1F;
    public static bool sunHasSet = false;



    void Update()
    {
        
            sunset.color = sunTints.Evaluate(PlayerJourney.percentage);
    }
}
