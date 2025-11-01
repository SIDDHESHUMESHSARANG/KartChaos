using UnityEngine;

public class spawnObstacle : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -12;
    LogicManagement logic;
    public AudioClip hitAudioClip;

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
            Debug.Log("Obstacle Deleted");
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Kart"))
        {
            logic.TakeDamage(20);
            
            if (hitAudioClip != null)
            {
                AudioSource.PlayClipAtPoint(hitAudioClip, transform.position);
            }
        }
    }
}
