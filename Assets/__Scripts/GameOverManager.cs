using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverScreen; // Reference to the game over screen UI object
    public Text scoreText;            // Reference to the UI Text component that shows the score

    void Start()
    {
        // Initially hide the game over screen
        gameOverScreen.SetActive(false);
    }

    // Non-static method - show the game over screen and update the score
    public void ShowGameOverScreen(int score)
    {
        // Display the game over screen
        gameOverScreen.SetActive(true);

        // Update the score text on the game over screen
        scoreText.text = "Final Score: " + score.ToString();
        Time.timeScale = 0;
    }
}
