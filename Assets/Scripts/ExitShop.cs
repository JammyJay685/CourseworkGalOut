using UnityEngine;

public class ExitShop : MonoBehaviour
{
    // Reference to the UI_Shop GameObject
    [SerializeField] private GameObject UI_Shop;

    // Method to close the shop UI
    public void CloseShop()
    {
        UI_Shop.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
// Jamie