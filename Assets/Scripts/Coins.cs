using UnityEngine;
using TMPro;

public class Coins : MonoBehaviour
{
    // Saves the player coin count to a variable
    public static float coinCount;
    public TMP_Text CoinText;
    void Start()
    {
        CoinText = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        CoinText.text = "$" + coinCount;
    }
}