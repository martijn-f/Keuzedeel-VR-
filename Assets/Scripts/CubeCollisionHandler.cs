using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class CubeCollisionHandler : MonoBehaviour
{
    public Text scoreText;

    private int score = 0;
    private HashSet<GameObject> collidedCubes = new HashSet<GameObject>();

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            GameObject cube = collision.gameObject;

            if (!collidedCubes.Contains(cube))
            {
                collidedCubes.Add(cube);
                UpdateScore();
            }
        }
    }

    void UpdateScore()
    {
        score = collidedCubes.Count;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
