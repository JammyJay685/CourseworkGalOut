using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;
    public float reward = 10f;
    public void TakeDamage (float amount){
        health -= amount;
        if (health <= 0){
            Die();
        }
    }
    void Die(){
        Destroy(gameObject);
        Coins.coinCount += reward;
    }
}
// Jamie