using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCounter : MonoBehaviour
{
    private int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basketball"))
        {
            // Increase the score when the basketball enters the trigger area
            score++;
            Debug.Log("Score: " + score);
        }
    }
}

