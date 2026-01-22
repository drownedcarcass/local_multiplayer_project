using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryButton : MonoBehaviour
{
    public void Retry()
    {
        if (!string.IsNullOrEmpty(LevelManager.lastLevelName))
        {
            SceneManager.LoadScene(LevelManager.lastLevelName); // Laad het level opnieuw
        }
    }
}
