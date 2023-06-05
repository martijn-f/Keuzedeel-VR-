using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    public ScoreManager3 scoreManager;
    public Transform[] cubeSpawnPoints;
    public GameObject[] cubesToReset;

    private void Start()
    {
        Button resetButton = GetComponent<Button>();
        resetButton.onClick.AddListener(ResetGame);
    }

    private void ResetGame()
    {
        scoreManager.Score = 0;
        Debug.Log("Score Reset");

        foreach (GameObject cube in cubesToReset)
        {
            // Reset cube's position and state
            cube.transform.position = GetRandomSpawnPoint();
            cube.SetActive(true);
        }
    }

    private Vector3 GetRandomSpawnPoint()
    {
        int randomIndex = Random.Range(0, cubeSpawnPoints.Length);
        return cubeSpawnPoints[randomIndex].position;
    }
}
