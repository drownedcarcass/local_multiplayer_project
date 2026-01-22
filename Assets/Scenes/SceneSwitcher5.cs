using UnityEngine;
using UnityEngine.SceneManagement; // Nodig om scènes te laden

public class SceneSwitcher5 : MonoBehaviour
{
    // Deze functie kan je aan een knop koppelen
    public void GoToControls2()
    {
        // Laad de scène op basis van naam
        SceneManager.LoadScene("Controls2");

        // OF laad de scène op basis van Build Index
        // SceneManager.LoadScene(3);
    }
}