using UnityEngine;

public class GroundTile : MonoBehaviour {

    GroundSpawner groundSpawner;

    private void Start () {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
	}

    private void OnTriggerExit (Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    public GameObject[] obstaclePrefabs;

    void SpawnObstacle()
    {
        int obstaclePrefabIndex = Random.Range(0, obstaclePrefabs.Length);
    int obstacleSpawnIndex = Random.Range(2, 5);
    Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

    Instantiate(obstaclePrefabs[obstaclePrefabIndex], spawnPoint.position, Quaternion.identity, transform);
    }

  
}