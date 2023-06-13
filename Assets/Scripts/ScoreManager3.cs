using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager3 : MonoBehaviour
{
    public Text scoreText;
    public AudioClip collisionSound;
    private int score = 0;
    private HashSet<GameObject> cubes = new HashSet<GameObject>();
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component or add a new one if none exists
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

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
        else if (collision.gameObject.CompareTag("Ground"))
        {
            PlayCollisionSound();
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

    private void PlayCollisionSound()
    {
        if (collisionSound != null)
        {
            audioSource.PlayOneShot(collisionSound);
        }
    }
}
