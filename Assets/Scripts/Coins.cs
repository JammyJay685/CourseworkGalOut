using UnityEngine;
using TMPro;

public class Coins : MonoBehaviour
{
    // Saves the player coin count to a global variable
    public static float coinCount;
    // Saves a Text Mesh Pro text as a variable
    public TMP_Text CoinText;
    void Start()
    {
        // Grabs the text mesh pro object
        CoinText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        // Sets the text mesh pro to the coin count
        CoinText.text = "$" + coinCount;
    }
}
// Jamie