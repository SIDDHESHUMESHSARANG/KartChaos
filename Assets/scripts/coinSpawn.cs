using UnityEngine;

public class coinSpawn : MonoBehaviour
{

    public GameObject coin;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffset = 10;
    public LayerMask obstacleLayer;
    public float overlapCircleRadius = 0.5f;

    LogicManagement logic;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagement>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate && logic.isHealthZero == false)
        {
            SpawnCoin();
            timer = 0;
        }
    }
    void SpawnCoin()
    {
        float lowestPoint = -3f;
        float highestPoint = 3.7f;

        Vector3 spawnPosition;
        for (int i = 0; i < 50; i++)
        {
            spawnPosition = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0);

            Collider2D hit = Physics2D.OverlapCircle(spawnPosition, overlapCircleRadius * 1.5f, obstacleLayer);

            Collider2D coinHit = Physics2D.OverlapCircle(spawnPosition, overlapCircleRadius * 1.5f, LayerMask.GetMask("Coin")); // Assuming you have a "Coin" layer

            if (hit == null && coinHit == null)
            {
                Instantiate(coin, spawnPosition, transform.rotation);
                return;
            }
        }

        Debug.LogWarning("Could not find a valid spawn position for the coin.");
    }

}