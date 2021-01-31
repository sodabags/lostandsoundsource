using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveObstacles : MonoBehaviour
{
    bool lightIsActivated;
    public GameObject privateLight;
    public GameObject revealAnimation;
    public bool hasPrivateLight;
    private GameObject newLight;

    private void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!lightIsActivated)
        {
            lightIsActivated = true;
            print("something hit the trigger");
            //collision.gameObject.SendMessage("illuminatedObject", true);
            PlayerController player = FindObjectOfType<PlayerController>();
            player.illuminatedObject(true);
            print("sending message to bat");
            if (hasPrivateLight)
            {
                var newLight = Instantiate(privateLight);
                newLight.transform.SetParent(this.transform);
                newLight.transform.position = this.transform.position;
            }
            Animator anim = revealAnimation.GetComponent<Animator>();
            anim.SetTrigger("reveal");
         
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("something hit  my collider!");
            PlayerController player = FindObjectOfType<PlayerController>();
            player.backToStart();
        }
        Animator anim = revealAnimation.GetComponent<Animator>();
        anim.SetTrigger("reveal");
        newLight = Instantiate(privateLight);
        newLight.transform.SetParent(this.transform);
        newLight.transform.position = this.transform.position;
        Invoke("DestroyPrivateLight", 1f);
    }

    void DestroyPrivateLight()
    {
        Destroy(newLight);
    }
}
