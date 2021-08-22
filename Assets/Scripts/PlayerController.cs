using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    [SerializeField] float upwardForce = 10.0f;

    public TMP_Text scoreText;
    public GameManager gameManager;
    public ParticleSystem starParticles;
    public ParticleSystem playerDeathParticle;
    public UnityEvent OnPlayerDeath;

    int score = 0;
    int colorNumber;
    int playerColorNumber;

    bool gameOver = false;

    Rigidbody2D rb;
    Dictionary<int, string> colorChooserDictionary;

    //
    // AWAKE
    //
    private void Awake()
    {
        InitializeVariables();
    }


    //
    // START
    //
    void Start()
    {
        playerColorNumber = 0;
        gameObject.GetComponent<SpriteRenderer>().color = Color.red;
        gameObject.tag = "RED";



        /*
        colorChooserDictionary.Add(0, "RED");
        colorChooserDictionary.Add(1, "BLUE");
        colorChooserDictionary.Add(2, "GREEN");
        colorChooserDictionary.Add(3, "PURPLE");
        foreach (var item in colorChooserDictionary)
        {
            Debug.Log(item);

        }
        */

        gameOver = false;

        


    }

    //
    // UPDATE
    //
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * upwardForce, ForceMode2D.Impulse);
            FindObjectOfType<AudioManager>().Play("PlayerTap");
        }
    }


    //
    // Methods
    //
    void InitializeVariables()
    {
        rb = GetComponent<Rigidbody2D>();
        colorChooserDictionary = new Dictionary<int, string>();


    }

    void PickPlayerColor()
    {
        colorNumber = UnityEngine.Random.Range(0, 4);
        if (colorNumber == playerColorNumber)
        {
            Debug.Log("Change Color");
            PickPlayerColor();
        }
        else
        {
            switch (colorNumber)
            {
                case 0:
                    gameObject.tag = "RED";
                    gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                    playerColorNumber = colorNumber;
                    break;
                case 1:
                    gameObject.tag = "BLUE";
                    gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
                    playerColorNumber = colorNumber;
                    break;
                case 2:
                    gameObject.tag = "GREEN";
                    gameObject.GetComponent<SpriteRenderer>().color = Color.green;
                    playerColorNumber = colorNumber;
                    break;
                case 3:
                    gameObject.tag = "PURPLE";
                    gameObject.GetComponent<SpriteRenderer>().color = Color.gray;
                    playerColorNumber = colorNumber;
                    break;
                default:
                    gameObject.tag = "RED";
                    gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                    playerColorNumber = colorNumber;
                    break;
            }
            Debug.Log("Keep this color");
        }
        
    }

    //---------------------------------------------------
    // When the player enters any trigger, check the tags
    //---------------------------------------------------
    private void OnTriggerEnter2D(Collider2D collision)
    {

        // Same color as the player, nothing happens
        if (gameObject.tag == collision.gameObject.tag)
        {
            Debug.Log("Same Same tag");
        }
        // Star Pickup
        else if (collision.tag == "STAR")
        {
            // Instantiate a new particle object on the star parent and destroy the star
            GameObject particleObject = Instantiate(starParticles.gameObject, collision.gameObject.transform.parent);
            Destroy(collision.gameObject);

            // Fix that up, score added somwhere else
            score += 1;
            scoreText.SetText(score.ToString());
            FindObjectOfType<AudioManager>().Play("StarPickup");

        }
        // Color changer Pickup
        else if (collision.tag == "COLORCHANGER")
        {
            PickPlayerColor();
            Destroy(collision.gameObject);
            FindObjectOfType<AudioManager>().Play("ColorChangerPickup");
        }
        else
        // Touched a trap, you die.
        {
            // Instatiate deathParticle, set it to the player location, destroy player
            GameObject particleObject = Instantiate(playerDeathParticle.gameObject);
            particleObject.transform.position = gameObject.transform.position;
            FindObjectOfType<AudioManager>().Play("Death");

            OnPlayerDeath?.Invoke();


            Destroy(gameObject);
            gameOver = true;
            Debug.Log(gameOver + "death");
        }
    }
}

