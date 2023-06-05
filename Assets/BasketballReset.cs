using UnityEngine;

public class BasketballReset : MonoBehaviour
{
    private Vector3 initialPosition;
    public ScoreManager2 scoreManager;
    private bool hasScored = false;

    private void Start()
    {
        // Store the initial position of the basketball
        initialPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trigger") && !hasScored)
        {
            // Increase the score when the basketball enters the trigger area for the first time
            hasScored = true;
            if (scoreManager != null)
            {
                scoreManager.IncreaseScore();
                scoreManager.UpdateScoreUI();
            }
        }
    }

    public void ResetBasketballPosition()
    {
        // Reset the basketball's position to the initial position
        transform.position = initialPosition;
        hasScored = false; // Reset the hasScored flag
    }
}
