using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSummonerBoss : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public int maxEnemies = 5;
    public float summonInterval = 3f;
    public float minSpawnDistance = 2f;
    public float maxSpawnDistance = 5f;

    private int currentEnemies = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SummonEnemy", 0f, summonInterval);    
    }
    
    void SummonEnemy()
    {
        if(currentEnemies < maxEnemies)
        {
            GameObject enemyPrefab = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];

            float spawnDistance = Random.Range(minSpawnDistance, maxSpawnDistance);
            float angle = Random.Range(0f, 360f);

            Vector3 spawnPosition = transform.position + Quaternion.Euler(0f, angle, 0f) * Vector3.forward * spawnDistance;

            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
            currentEnemies++;
        }
    }
}
