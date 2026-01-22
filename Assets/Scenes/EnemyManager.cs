using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
    public static int totalEnemies;
    public static int enemiesAlive;

    public TextMeshProUGUI enemiesText;

    private static EnemyManager instance;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        totalEnemies = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemiesAlive = totalEnemies;
        UpdateUI();
    }

    public static void EnemyDied()
    {
        enemiesAlive--;

        if (instance != null)
        {
            instance.UpdateUI();
        }

        if (enemiesAlive <= 0)
        {
            SceneManager.LoadScene("Spelscherm Level 2");
        }
    }

    void UpdateUI()
    {
        enemiesText.text = "Enemies: " + enemiesAlive + "/" + totalEnemies;
    }
}
