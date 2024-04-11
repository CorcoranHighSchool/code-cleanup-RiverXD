using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //Prefab for the obstacle to spawn
    [SerializeField] private GameObject obstaclePrefab;
    //Spawn Position
    private Vector3 spawnPos = new Vector3(25.0f, 0.0f, 0.0f);

    //Spawn delay
    private float spawnDelay = 2.0f;
    //Spawn Rate
    private float spawnRate = 2.0f;
    private string const spawnobstacle = "SpawnObstacle";
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(spawnobstacle, spawnDelay, spawnRate);
    }

    private void SpawnObstacle()
    {
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
