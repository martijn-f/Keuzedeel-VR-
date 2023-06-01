using UnityEngine;
using UnityEngine.UI;

public class ScoreResetButton : MonoBehaviour
{
    public ScoreManager2 scoreManager;

    private void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(ResetScore);
    }

    private void ResetScore()
    {
        if (scoreManager != null)
        {
            scoreManager.ResetScore();
        }
    }
}
