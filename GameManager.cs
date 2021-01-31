using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //SET THESE 3 transforms in Inspector:
    public Transform player;
    public Transform journeyStart;
    public Transform journeyEnd;
    //public Slider Progress;
    public PlayerController playerController;
    public GameObject Hint1, Hint2, Hint3;
    public static float percentage;

    private void Awake()
    {
        //Progress.gameObject.SetActive(false);
        Hint1.SetActive(false);
        Hint2.SetActive(false);
        Hint3.SetActive(false);
        Invoke("RevealHints", 15);
    }

    void Update()
    {
        percentage = Mathf.Lerp(0f, 1f, Mathf.InverseLerp(journeyStart.transform.position.y, journeyEnd.transform.position.y, player.transform.position.y));
        //Debug.Log(percentage);
        if (playerController.tutorialComplete)
        {
            //Progress.gameObject.SetActive(true);
        }
    }

    void RevealHints()
    {
        if (!playerController.tutorialComplete)
        {
            Hint1.SetActive(true);
            Hint2.SetActive(true);
            Hint3.SetActive(true);
            Invoke("CloseHints", 15);
        }

    }

    void CloseHints()
    {
        Hint1.SetActive(false);
        Hint2.SetActive(false);
        Hint3.SetActive(false);
    }
}
