using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartSequence : MonoBehaviour
{
    public string newGameScene;
    public Image title;
    public GameObject CaveSounds;
    public GameObject BatSonar;
    public GameObject Gasp;
    public GameObject Drone;
    public GameObject DripSound;

    // Start is called before the first frame update
    void Start()
    {
        BatSonar.SetActive(false);
        DontDestroyOnLoad(CaveSounds);
        Gasp.SetActive(false);
        Drone.SetActive(false);
        DripSound.SetActive(false);
        StartCoroutine(FadeTitle());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator FadeTitle()
    {
        yield return new WaitForSeconds(3);
        title.CrossFadeAlpha(0f, 2.0f, false);
        Drone.SetActive(true);
        yield return new WaitForSeconds(2f);
        DripSound.SetActive(true);
        yield return new WaitForSeconds(2f);
        BatSonar.SetActive(true);
        yield return new WaitForSeconds(2f);
        Gasp.SetActive(true);
        yield return new WaitForSeconds(2f);
        NewGame();
    }

    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
    }

}
