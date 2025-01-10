using UnityEngine;

public class TriggerShop : MonoBehaviour
{
    // Reference to the UI_Shop GameObject
    [SerializeField] private GameObject UI_Shop;

    // Called when another collider enters this trigger
    private void OnTriggerEnter(Collider other)
    {
        // Check if the player entered the trigger
        if (other.CompareTag("Player"))
        {
            // Activate the UI_Shop
            UI_Shop.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
// Jamie
