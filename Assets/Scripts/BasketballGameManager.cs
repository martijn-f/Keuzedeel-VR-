using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasketballGameManager : MonoBehaviour
{
    public Button resetButton;
    public AudioClip buttonSound;
    private AudioSource audioSource;
    private List<ScoreManager2> scoreManagers = new List<ScoreManager2>();

    private void Start()
    {
        // Attach a method to the button's onClick event
        resetButton.onClick.AddListener(ResetGame);

        // Get the AudioSource component attached to the game object or create a new one if none exists
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        // Find all instances of the ScoreManager2 script in the scene and add them to the list
        ScoreManager2[] foundScoreManagers = FindObjectsOfType<ScoreManager2>();
        scoreManagers.AddRange(foundScoreManagers);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basketball"))
        {
            // Increase the score when a basketball enters the trigger area
            foreach (ScoreManager2 manager in scoreManagers)
            {
                manager.IncreaseScore();
                manager.UpdateScoreUI(); // Update the score UI after increasing the score
            }
        }
    }

    private void ResetGame()
    {
        // Reset the positions of all basketballs in the scene
        BasketballReset[] basketballResets = FindObjectsOfType<BasketballReset>();
        foreach (BasketballReset reset in basketballResets)
        {
            reset.ResetBasketballPosition();
        }

        // Reset the score in all ScoreManager2 instances
        foreach (ScoreManager2 manager in scoreManagers)
        {
            manager.ResetScore();
            manager.UpdateScoreUI(); // Update the score UI after resetting the score
        }

        // Play the button sound
        if (buttonSound != null)
        {
            audioSource.PlayOneShot(buttonSound);
        }
    }
}
