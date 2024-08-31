using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerManager : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    private Transform playerPosition;
    [SerializeField] Vector2 spawnArea;
    [SerializeField] float spawnTimer;
    float timer;

    private void Start()
    {
        timer = spawnTimer;
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer < 0.0f)
        {
            SpawnEnemy();
            timer = spawnTimer;
        }
    }

    private void SpawnEnemy()
    {
        Vector2 position = new Vector2(
            UnityEngine.Random.Range(playerPosition.position.x - spawnArea.x, playerPosition.position.x + spawnArea.x),
            UnityEngine.Random.Range(playerPosition.position.y - spawnArea.y, playerPosition.position.y + spawnArea.y));

        GameObject newEnemy = Instantiate(enemy, position, Quaternion.identity);
        //newEnemy.transform.position = position;
    }
}
