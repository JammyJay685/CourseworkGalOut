using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    public void BuyDamage()
    {
        // Checks to see if the player has enough coins
        if (Coins.coinCount >= 150){
            // Applies the upgrade and removes the coins
            Shooter.damage += 10;
            Coins.coinCount -= 150;
        }
    }
    public void BuyHealth()
    {
        // Checks to see if the player has enough coins
        if (Coins.coinCount >= 100){
            // Applies the upgrade and removes the coins
            PlayerHealth.xPlayerHealth += 100;
            Coins.coinCount -= 100;
        }
    }
}
// Jamie