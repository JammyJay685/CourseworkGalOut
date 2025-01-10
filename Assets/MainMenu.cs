using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        // Load the main game scene 
        SceneManager.LoadScene("SpaceOutlaws0.3");
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game"); 
        Application.Quit(); 
    }
}
