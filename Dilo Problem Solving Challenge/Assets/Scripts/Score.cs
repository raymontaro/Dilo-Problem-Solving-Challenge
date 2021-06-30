using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static Score Instance;

    public int currentScore = 1;

    public GameObject gameOverPanel;
    public GameObject winPanel;

    Text text;

    public int boxCount;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        text = GetComponent<Text>();
        text.text = "No: " + currentScore;
    }    

    public void AddScore(int value)
    {
        currentScore += value;

        text.text = "No: " + currentScore;

        if (currentScore > boxCount)
        {
            Win();
        }
    }

    public void Win()
    {
        winPanel.SetActive(true);
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(0);
    }
}
