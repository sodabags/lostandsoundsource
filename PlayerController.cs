using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


//ASSIGN IN INSPECTOR:
//Laser prefab
//Fire Pos = Player's transform

public class PlayerController : MonoBehaviour
{
    public GameObject lightLaserPrefab;
    public GameObject endVoiceOver;
    public Transform firePos;
    //public Animator pulse_anim;
    public Animator bat_anim;
    private bool readyToShoot;
    private float _shootCoolDown = 0f;
    public float howLongforCoolDown = .1f;
    Rigidbody2D rb;
    public float sidespeed = 10f;
    public bool tutorialComplete;
    public bool MovingLeft;
    public bool MovingRight;
    public float maxHeight = 115;
    //public float heightToTriggerEndVoiceOver = 114;
    public bool isPlayerMoving;
    public float collisionCoroutineWaitTime = .5f;
    public AudioSource beep;
    public GameObject cantSonarFeedback;

    public AudioSource collisionSound;
    public AudioClip[] audioSources;

    [SerializeField]
    private float _speed;

    private void Start()
    {
        _speed = 1;
        endVoiceOver.SetActive(false);
        rb = gameObject.GetComponent<Rigidbody2D>();
        isPlayerMoving = true;
    }
    void Update()
    {
        
            CalculateMovement();
        
            
        Shoot();
        FinishLine();
    }

    private void CalculateMovement()
    {
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            bat_anim.SetBool("MovingLeft", true);
            MovingLeft = true;
            bat_anim.SetBool("MovingRight", false);
            MovingRight = false;
            GetComponent<AudioSource>().Play();
        }
        if (Keyboard.current.leftArrowKey.wasReleasedThisFrame)
        {
            MovingLeft = false;
            bat_anim.SetBool("MovingLeft", false);
        }
            if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            bat_anim.SetBool("MovingLeft", false);
            MovingLeft = false;
            bat_anim.SetBool("MovingRight", true);
            MovingRight = true;
        }
        if (Keyboard.current.rightArrowKey.wasReleasedThisFrame)
        {
            MovingRight = false;
            bat_anim.SetBool("MovingRight", false);
        }
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            _speed = 10;
        }
        
        if (Keyboard.current.upArrowKey.wasReleasedThisFrame)
        {
            _speed = 1;
        }
            if (MovingLeft)
        {
            rb.AddForce(Vector2.left * sidespeed);
        }
        if (MovingRight)
        {
            rb.AddForce(Vector2.right * sidespeed);
        }
        //if (transform.position.y > heightToTriggerEndVoiceOver)
        //{
            //EndingVoiceOver();
        //}
        if (isPlayerMoving)
        {
            MoveForward();
        }
        if (transform.position.x > 8.5f)
        {
            transform.position = new Vector3(8.5f, transform.position.y, 0);

        }
        else if (transform.position.x < -8.5f)
        {
            transform.position = new Vector3(-8.5f, transform.position.y, 0);
        }
    }

    void MoveForward()
    {
        if (tutorialComplete)
        {
            rb.AddForce(Vector2.up * _speed);
        }

    }

    void FinishLine()
    {
        if (transform.position.y >= maxHeight)
        {
            isPlayerMoving = false;
            readyToShoot = false;
            SceneManager.LoadScene(2);
        }
    }

    private void Shoot()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !readyToShoot)
        {
            cantSonarFeedback.SetActive(true);
        }

        if (Keyboard.current.spaceKey.wasPressedThisFrame && readyToShoot)
        {
            Instantiate(lightLaserPrefab, firePos.position, Quaternion.Euler(lightLaserPrefab.GetComponent<Transform>().rotation.eulerAngles));
            readyToShoot = false;
            _shootCoolDown = howLongforCoolDown;
            //pulse_anim.SetTrigger("pulse");
            print("shooting");
            
            beep.pitch = Random.Range(0.6f, 1.2f);
            beep.Play();

        }
        _shootCoolDown -= Time.deltaTime;
        if (_shootCoolDown <= 0)
        {
            _shootCoolDown = 0;
            //pulse_anim.ResetTrigger("pulse");
            readyToShoot = true;
        }
        
        
    }

    public void illuminatedObject(bool value)
    {
        tutorialComplete = value;
        print("received tutorial message");
    }

    public void backToStart()
    {
        StartCoroutine(backToStartCoroutine());
    }

    IEnumerator backToStartCoroutine()
    {
        isPlayerMoving = false;
        SpriteRenderer sprite = this.GetComponent<SpriteRenderer>();
        float transparency = .3f;
        sprite.color = new Color(1f, 1f, .5f, transparency);
        yield return new WaitForSeconds(collisionCoroutineWaitTime);
        collisionSound.clip = audioSources[Random.Range(0, audioSources.Length)];
        collisionSound.Play();
        sprite.color = new Color(1f, 1f, 1f, 1f);
        yield return new WaitForSeconds(collisionCoroutineWaitTime);
        this.transform.position = new Vector3(0, 0, 0);
        sprite.color = new Color(1f, 1f, 1f, transparency);
        yield return new WaitForSeconds(collisionCoroutineWaitTime);
        isPlayerMoving = true;
        sprite.color = new Color(1f, 1f, 1f, 1f);
    }

        private void EndingVoiceOver()
    {
        
        endVoiceOver.SetActive(true);
    }
}
