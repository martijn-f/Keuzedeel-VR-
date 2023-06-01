using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GroundCollisionHandler2 : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    private HashSet<GameObject> Basketballs = new HashSet<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Basketball"))
        {
            GameObject cube = other.gameObject;

            if (!Basketballs.Contains(cube))
            {
                Basketballs.Add(cube);
                score = Basketballs.Count;
                UpdateScoreUI();
            }
        }
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}

