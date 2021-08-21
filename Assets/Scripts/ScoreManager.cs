using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int score = 0;


    public void AddToScore()
    {
        score += 1;
        Debug.Log(score);
    }
}
