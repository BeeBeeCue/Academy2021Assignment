using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UnityEvent StarPickedUp;
    ScoreManager sm;
    public TMP_Text score;

    private void Start()
    {
        ResetTheScore();
        ResetPlayerPosition();
    }


    // When level is reset, reset player position to the start
    void ResetPlayerPosition()
    {
       
    }

    // Reset the score    
    void ResetTheScore()
    {
        score.SetText("0");
    }
}
