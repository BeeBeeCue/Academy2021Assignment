using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;


public class GameManager : MonoBehaviour
{
    public TMP_Text score;

    public Color RED = new Color(1f, 0f, 0f);
    public Color GREEN = new Color(0f, 1f, 0f);
    public Color BLUE = new Color(0f, 0f, 1f);
    public Color PURPLE = new Color(1f, 0f, 1f);

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
