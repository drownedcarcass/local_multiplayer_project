using UnityEngine;
using UnityEngine.SceneManagement; // Nodig om scènes te laden

public class SceneSwitcher3 : MonoBehaviour
{
    // Deze functie kan je aan een knop koppelen
    public void GoToStartscherm()
    {
        // Laad de scène op basis van naam
        SceneManager.LoadScene("Startscherm");

        // OF laad de scène op basis van Build Index
        // SceneManager.LoadScene(3);
    }
}
