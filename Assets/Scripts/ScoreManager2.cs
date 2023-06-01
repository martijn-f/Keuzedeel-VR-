using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager2 : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    private HashSet<GameObject> countedBasketballs = new HashSet<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basketball"))
        {
            GameObject basketball = other.gameObject;

            if (!countedBasketballs.Contains(basketball))
            {
                countedBasketballs.Add(basketball);
                score++;
                UpdateScoreUI();
            }
        }
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    public void ResetScore()
    {
        countedBasketballs.Clear(); // Clear the set to allow counting basketballs again
        score = 0;
        UpdateScoreUI();
    }
}
