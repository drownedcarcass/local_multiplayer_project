using UnityEngine;
using UnityEngine.SceneManagement; // Nodig om scènes te laden

public class SceneSwitcher : MonoBehaviour
{
    // Deze functie kan je aan een knop koppelen
    public void GoToControls()
    {
        // Laad de scène op basis van naam
        SceneManager.LoadScene("Controls");

        // OF laad de scène op basis van Build Index
        // SceneManager.LoadScene(1);
    }
}
