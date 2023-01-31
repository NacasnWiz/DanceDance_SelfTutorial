using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text playerScoreText;
    public double spawnRate = 2;

    [ContextMenu("Increase score")]
    public void addScore()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
    }
    public void addScore(int scoreToAdd)
    {
        playerScore += scoreToAdd;
        playerScoreText.text = playerScore.ToString();
    }
}
