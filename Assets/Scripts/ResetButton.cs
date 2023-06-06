using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    private Vector3 initialPosition;
    public Button resetButton;
    public AudioClip buttonSound;
    private AudioSource audioSource;
    private ScoreManager scoreManager;

    private void Start()
    {
        // Store the initial position of the cube
        initialPosition = transform.position;

        // Attach a method to the button's onClick event
        resetButton.onClick.AddListener(ResetCubePosition);

        // Get the AudioSource component attached to the cube or create a new one if none exists
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Find the ScoreManager in the scene
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    private void ResetCubePosition()
    {
        // Reset the cube's position to the initial position
        transform.position = initialPosition;

        // Play the button sound
        if (buttonSound != null)
        {
            audioSource.PlayOneShot(buttonSound);
        }

        // Reset the score by calling the ResetScore method in the ScoreManager
        if (scoreManager != null)
        {
            scoreManager.ResetScore();
        }
    }
}
