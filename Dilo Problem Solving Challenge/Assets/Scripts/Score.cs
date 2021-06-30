using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score Instance;

    public int currentScore = 0;

    Text text;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        text = GetComponent<Text>();
    }

    public void AddScore(int value)
    {
        currentScore += value;

        text.text = "Score: " + currentScore;
    }
}
