using UnityEngine;
using TMPro;
using System;

public class ScoreSystem : MonoBehaviour
{

    private int score = 0;
    private TMP_Text textField;

    private void Start()
    {
        textField = GetComponent<TMP_Text>();
        UpdateScoreText();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        textField.text = "Score: " + score.ToString();
    }

}
