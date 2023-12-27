using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taret : MonoBehaviour
{

    [SerializeField] GameObject enemyPrefab;
    [SerializeField] float enemySpeed;

    private float spawnTimer = 0f;
    private float spawnInterval = 1f;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
        spawnTimer += Time.fixedDeltaTime;

        if (spawnTimer >= spawnInterval)
        {
            SpawnEnemy();
            spawnTimer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position , enemyPrefab.transform.rotation);
    }

    
}
