using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;


public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float upwardForce = 10.0f;
    public TMP_Text scoreText;
    int score = 0;

    Rigidbody2D rb;
    public GameManager gameManager;
    public ParticleSystem starParticles;
    public ParticleSystem playerDeathParticle;
    int colorNumber;

    UnityEvent starPickedUpSendToGameManager;
    
    void Start()
    {
        InitializeVariables();
        PickPlayerColor();
    }
    void InitializeVariables()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void PickPlayerColor()
    {
        colorNumber = Random.Range(0, 3);
        switch (colorNumber)
        {
            case 0:
                gameObject.tag = "RED";
                gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                break;
            case 1:
                gameObject.tag = "BLUE";
                gameObject.GetComponent<SpriteRenderer>().color = Color.blue;
                break;
            case 2:
                gameObject.tag = "GREEN";
                gameObject.GetComponent<SpriteRenderer>().color = Color.green;
                break;
            case 3:
                gameObject.tag = "PURPLE";
                gameObject.GetComponent<SpriteRenderer>().color = Color.cyan;
                break;
            default:
                gameObject.tag = "RED";
                gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                break;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * upwardForce, ForceMode2D.Impulse);
        }    
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == collision.gameObject.tag)
        {
            Debug.Log("Same Same tag");
        }
        else if (collision.tag == "STAR")
        {
            // Instantiate a new particle object on the star parent and destroy the star
            GameObject particleObject = Instantiate(starParticles.gameObject, collision.gameObject.transform.parent);
            Destroy(collision.gameObject);

            // Fix that up, score added somwhere else
            //starPickedUpSendToGameManager.Invoke();
            score += 1;
            scoreText.SetText(score.ToString());

        }
        else if (collision.tag == "COLORCHANGER")
        {
            PickPlayerColor();
            Destroy(collision.gameObject);
        }
        else
        {
            // Instatiate deathParticle, set it to the player location, destroy player
            GameObject particleObject = Instantiate(playerDeathParticle.gameObject);
            particleObject.transform.position = gameObject.transform.position;
            Destroy(gameObject);
        }
    }  
}

