using UnityEngine;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject obstacle;
    public float spawnRate;
    public float timer = 0;

    LogicManagement logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagement>();

        if (timer >= spawnRate && logic.isHealthZero == false)
        {
            SpawnObstacle();
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate && logic.isHealthZero == false)
        {
            SpawnObstacle();
            timer = 0;
        }
    }

    void SpawnObstacle()
    {
        float lowestPoint = -3f;
        float highestPoint = 3.7f;

        Instantiate(obstacle, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
