using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemySpawning : MonoBehaviour
{
    public double growthRate;
    public double startTimer;
    public GameObject EnemyPrefab;
    bool random;
    Vector3 position;
    float yRotation;
    float timeUntillNextSpawn;
    int enemiesSpawned = 0;

    void OnEnable()
    {
        enemiesSpawned = 0;
        timeUntillNextSpawn = Convert.ToSingle(startTimer);
        random = false;
        SpawnEnemy();
    }

    void Update()
    {
        if (timeUntillNextSpawn > 0)
        {
            timeUntillNextSpawn -= Time.deltaTime;
            print(Progression(enemiesSpawned));
        }
        else
        {
            SpawnEnemy();
            enemiesSpawned += 1;
            timeUntillNextSpawn = Progression(enemiesSpawned);
            if (enemiesSpawned == 10)
            {
                random = true;
            }
        }
    }
    float Progression(int x)
    {
        double result = startTimer * Math.Pow(growthRate, -x);
        return Convert.ToSingle(result);
    }

    void SpawnEnemy()
    {   
        int spawnPlace;
        if (random)
        {
            spawnPlace = UnityEngine.Random.Range(0,4);
        }
        else
        {
            spawnPlace = 3;
        }

        switch (spawnPlace)
        {
            case 0:
                position = new Vector3(0,5,-67);
                yRotation = UnityEngine.Random.Range(-60, 60);
                break;
            case 1:
                position = new Vector3(0,5,67);
                yRotation = UnityEngine.Random.Range(120, 240);
                break;
            case 2:
                position = new Vector3(-67,5,0);
                yRotation = UnityEngine.Random.Range(30, 150);
                break;
            case 3:
                position = new Vector3(67,5,0);
                yRotation = UnityEngine.Random.Range(-150, -30);
                break;
        }

        Quaternion rotation = Quaternion.Euler(0, yRotation, 0);

        Instantiate(EnemyPrefab, position, rotation);

    }


}
