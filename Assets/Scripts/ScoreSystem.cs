using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;

    private void Start()
    {
        Coins.OnCoinCollected += GetPoints;
    }

    private void OnDestroy()
    {
        Coins.OnCoinCollected -= GetPoints;
    }

    private void GetPoints()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }   


}
