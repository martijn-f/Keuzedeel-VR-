using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    private HashSet<GameObject> cubes = new HashSet<GameObject>();


    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            GameObject cube = collision.gameObject;


            if (!cubes.Contains(cube))
            {
                cubes.Add(cube);
                score = cubes.Count;
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

    public void ResetScore()
    {
        cubes.Clear();
        score = 0;
        UpdateScoreUI();
    }
}

