using UnityEngine;

public class Coin : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float deadZone = -12f;
    
    public AudioClip coinCollectSound;

    private LogicManagement logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagement>();
    }

    void Update()
    {
        if (logic.isHealthZero == false)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        }

        if (transform.position.x < deadZone)
            {
                Debug.Log("Coin Deleted (Off-screen)");
                Destroy(gameObject);
            }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Kart"))
        {
            if (coinCollectSound != null)
            {
                AudioSource.PlayClipAtPoint(coinCollectSound, transform.position);
            }
            
            logic.IncreaseScore();
            Debug.Log("Coin Collected");
            
            Destroy(gameObject);
        }
    }
}
