using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game afgesloten"); // Alleen zichtbaar in de Unity Editor
    }
}
