using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundCollisionHandler3 : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    private HashSet<GameObject> cubes = new HashSet<GameObject>();

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube2"))
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
}
