using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class GameController : MonoBehaviour
{
    public TMP_Text playerScoreText;
    public TMP_Text playerWinText;
    public int pointsToWin;
    public GameObject gameOverScreen;
    private int playerOneScore = 0;
    private int playerTwoScore = 0;
    public AudioSource scoreSound;
    public AudioSource backgroundSound;


    // Start is called before the first frame update
    void Start()
    {
        playerScoreText.text = "0/0";
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddScore(bool isPlayerOne)
    {
        if (isPlayerOne)
        {
            playerOneScore = playerOneScore + 1;
            if (playerOneScore >= pointsToWin)
            {
                playerWinText.text = "P1 WINS";
                gameOverScreen.SetActive(true);
                Time.timeScale = 0;
                backgroundSound.Pause();    
            }
        }
        else
        {
            playerTwoScore = playerTwoScore + 1;
            if (playerTwoScore >= pointsToWin)
            {
                playerWinText.text = "P2 WINS";
                gameOverScreen.SetActive(true);
                Time.timeScale = 0;
                backgroundSound.Pause();

            }
        }
        scoreSound.Play();
        playerScoreText.text = playerOneScore.ToString() + "/" + playerTwoScore.ToString();
    }


    public void RestartGame()
    {
    SceneManager.LoadScene("MenuScene");
        playerOneScore = 0;
        playerTwoScore = 0;

    }

}

