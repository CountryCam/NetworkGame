using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    public int score = 0; // Player's score
    public TextMesh scoreText; // Reference to a TextMesh for displaying the score

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("NetworkPlayer")) // Check if it's the player that collided with the coin
        {
            CollectCoin();
            Destroy(gameObject); // Remove the collected coin
        }
    }

    // Method to handle coin collection
    void CollectCoin()
    {
        // Increment the player's score
        score++;

        // Update the score display
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }

        // You can also add additional logic here, such as playing a sound effect or particle effect
    }
}
