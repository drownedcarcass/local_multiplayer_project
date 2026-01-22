using UnityEngine;
using UnityEngine.SceneManagement; // Nodig om scènes te laden

public class SceneSwitcher4 : MonoBehaviour
{
    // Deze functie kan je aan een knop koppelen
    public void GoToPauseMenu()
    {
        // Laad de scène op basis van naam
        SceneManager.LoadScene("Pause Menu");

        // OF laad de scène op basis van Build Index
        // SceneManager.LoadScene(3);
    }
}
