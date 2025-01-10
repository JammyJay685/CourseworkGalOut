using UnityEngine;
using UnityEngine.SceneManagement;

public class Minefield : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {            
            // Set player's health to 0
            PlayerHealth.xPlayerHealth = 0f;

            // Display Game Over scene
            SceneManager.LoadScene("GameOver");

            // Display Game Over logic 
            Debug.Log("Game Over!");
        }
    }
}
