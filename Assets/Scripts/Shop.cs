using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    // Update is called once per frame
    public void BuyDamage()
    {
        if (Coins.coinCount >= 150){
            Shooter.damage += 10;
            Coins.coinCount -= 150;
        }
    }
    public void BuyHealth()
    {
        if (Coins.coinCount >= 100){
            PlayerHealth.xPlayerHealth += 100;
            Coins.coinCount -= 100;
        }
    }
}
