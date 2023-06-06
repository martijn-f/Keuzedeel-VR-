using UnityEngine;

public class ScoreManager3 : MonoBehaviour
{
    private int score = 0;
    public TMPro.TextMeshProUGUI scoreText;

    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    private void Start()
    {
        UpdateScoreText();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube2"))
        {
            score++;
            Debug.Log("Score: " + score);
            UpdateScoreText();
            Destroy(collision.gameObject);
        }
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
