using UnityEngine;
using UnityEngine.SceneManagement; // Nodig om scènes te laden

public class SceneSwitcher2 : MonoBehaviour
{
    // Deze functie kan je aan een knop koppelen
    public void GoToSpelschermlevel1()
    {
        // Laad de scène op basis van naam
        SceneManager.LoadScene("Spelscherm Level 1");

        // OF laad de scène op basis van Build Index
        // SceneManager.LoadScene(2);
    }
}
