using UnityEngine;

public class Coin : MonoBehaviour
{
    // Public variables are editable in the Inspector
    MoveKart kart;
    public float moveSpeed = 5f;
    public float deadZone = -12f;
    
    // Assign your coin collection sound here in the Inspector
    public AudioClip coinCollectSound;

    // Private variables are not shown in the Inspector
    private LogicManagement logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagement>();
    }

    void Update()
    {
        // Move the coin to the left
        if (logic.isHealthZero == false)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        }

        // Check if the coin has moved past the "deadZone" and delete it
        if (transform.position.x < deadZone)
            {
                Debug.Log("Coin Deleted (Off-screen)");
                Destroy(gameObject);
            }
    }

    // Called when a 2D collider enters the trigger
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // Only trigger the collection logic if the colliding object is the player
        if (collision.gameObject.CompareTag("Kart"))
        {
            // Play the audio for coin collection
            // AudioSource.PlayClipAtPoint is a static method that plays the sound at a specified position
            // and manages its own AudioSource, which is ideal for one-off sound effects.
            if (coinCollectSound != null)
            {
                AudioSource.PlayClipAtPoint(coinCollectSound, transform.position);
            }
            
            logic.IncreaseScore();
            Debug.Log("Coin Collected");
            
            // Destroy the coin GameObject immediately after it is collected
            Destroy(gameObject);
        }
    }
}
