using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;


public class GameManager : MonoBehaviour
{
    [SerializeField] private UnityEvent StarPickedUp;
    public TMP_Text score;
    public PlayerController playerController;

    private void Start()
    {
        ResetTheScore();
    }

    // Reset the score    
    void ResetTheScore()
    {
        score.SetText("0");
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
