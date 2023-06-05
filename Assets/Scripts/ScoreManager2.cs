using UnityEngine;
using UnityEngine.UI;

public class ScoreManager2 : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;

    public void IncreaseScore()
    {
        score++;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
