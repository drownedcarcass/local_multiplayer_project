using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static string lastLevelName;

    void Awake()
    {
        DontDestroyOnLoad(gameObject); // Blijft bestaan tussen scenes
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Bewaar alleen echte levels, geen GameOver of StartMenu
        if (scene.name != "GameOver" && scene.name != "StartMenu")
        {
            lastLevelName = scene.name;
        }
    }
}
