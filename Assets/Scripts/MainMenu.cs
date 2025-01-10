using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Load the main game scene 
        SceneManager.LoadScene("SpaceOutlaws0.7");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game"); 
        Application.Quit(); 
    }
}
