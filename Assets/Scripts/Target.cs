using UnityEngine;

public class Target : MonoBehaviour
{
    // Variables that dictate the health of the object and the reward the player gets in coins
    public float health = 50f;
    public float reward = 10f;
    public void TakeDamage (float amount){
        // Remove health and if the amount of damage goes below health, die
        health -= amount;
        if (health <= 0){
            Die();
        }
    }
    void Die(){
        // Destroy the gameobject and give the player the amount of coins specified in rewards
        Destroy(gameObject);
        Coins.coinCount += reward;
    }
}
// Jamie