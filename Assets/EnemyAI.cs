using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private GameObject player; // Reference to the player object
    public float detectionRange = 20f; // How far the enemy can "see" the player
    public float moveSpeed = 5f; // Speed at which the enemy follows the player

    void Start()
    {
        // Find the GameObject tagged as "Player"
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player == null)
        {
            Debug.LogWarning("No GameObject with the 'Player' tag found!");
            return;
        }

        // Calculate the distance to the player
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceToPlayer <= detectionRange)
        {
            // Move toward the player
            Vector3 direction = (player.transform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;

            // Rotate to face the player
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        }
    }
}
