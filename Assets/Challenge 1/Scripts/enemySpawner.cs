using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemyPlanePrefab; 
    public float spawnInterval = 3.0f; 
    public Vector3 spawnRange = new Vector3(50, 20, 50);

    void Start()
    {
        
        InvokeRepeating("SpawnEnemyPlane", 2.0f, spawnInterval);
    }

    void SpawnEnemyPlane()
    {
       
        Vector3 randomPosition = new Vector3(
            Random.Range(-spawnRange.x, spawnRange.x),
            Random.Range(10, spawnRange.y),
            Random.Range(-spawnRange.z, spawnRange.z)
        );
        GameObject enemyPlane = Instantiate(enemyPlanePrefab, randomPosition, Quaternion.identity);

        // Düşman uçağına EnemyPlaneMovement script'ini ekleyin (Prefab'de otomatik olarak ekli değilse)
        if (enemyPlane.GetComponent<enemyplanemovement>() == null)
        {
            enemyPlane.AddComponent<enemyplanemovement>();
        }
    }
}
