using UnityEngine;
using UnityEngine.UI;

public class GroundCollisionHandler2 : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basketball"))
        {
            // Increase the score when the basketball enters the trigger area
            score++;
            UpdateScoreUI();
        }
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
