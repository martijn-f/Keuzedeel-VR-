using UnityEngine;

public class ScoreManager3 : MonoBehaviour
{
    public int Score { get; set; } // Public property to access and modify the score

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Target"))
        {
            Score++;
            Debug.Log("Score: " + Score);
        }
    }
}
