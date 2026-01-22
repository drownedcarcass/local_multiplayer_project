using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour

{
    public static int health = 6;
    public TextMeshProUGUI livesText;

    private void FixedUpdate()

    {
        livesText.text = health.ToString();
    }

    public static void TakeDamage()

    {
        health--;
        Debug.Log("Je hebt nog" + health + " health."); //waarde van totaal teruggeven aan Log
        if (health <= 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}


