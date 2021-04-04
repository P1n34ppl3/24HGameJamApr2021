using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemySpawning : MonoBehaviour
{
    public double growthRate;
    public double startTimer;
    public float spawnLimit;
    public GameObject EnemyPrefab;
    Vector3 position;
    float yRotation;
    float timeUntillNextSpawn;
    int enemiesSpawned = 0;
    int spawnPlace;
    int gateProgression;

    void OnEnable()
    {
        enemiesSpawned = 0;
        timeUntillNextSpawn = Convert.ToSingle(startTimer);
        gateProgression = 0;
        SpawnEnemy();
    }

    void Update()
    {
        if (timeUntillNextSpawn > 0)
        {
            timeUntillNextSpawn -= Time.deltaTime;
        }
        else
        {
            SpawnEnemy();
            enemiesSpawned += 1;
            timeUntillNextSpawn = Progression(enemiesSpawned);
            GateProgressor();
        }
    }
    float Progression(int x)
    {
        double result = startTimer * Math.Pow(growthRate, -x);
        if (result > spawnLimit)
        {
            return Convert.ToSingle(result);
        }
        else
        {
            return spawnLimit;
        }
    }

    void GateProgressor()
    {
        switch (enemiesSpawned)
            {
                case 10:
                    enemiesSpawned = 1;
                    break;
                case 20:
                    enemiesSpawned = 2;
                    break;
                case 30:
                    enemiesSpawned = 3;
                    break;
            }
    }

    void SpawnEnemy()
    {   
        switch (gateProgression)
        {
            case 0:
                spawnPlace = 3;
                break;
            case 1:
                spawnPlace = UnityEngine.Random.Range(2,4);
                break;
            case 2:
                spawnPlace = UnityEngine.Random.Range(1,4);
                break;
            case 3:
                spawnPlace = UnityEngine.Random.Range(0,4);
                break;
        }

        switch (spawnPlace)
        {
            case 0:
                position = new Vector3(0,5,-60);
                yRotation = UnityEngine.Random.Range(-60, 60);
                break;
            case 1:
                position = new Vector3(0,5,60);
                yRotation = UnityEngine.Random.Range(120, 240);
                break;
            case 2:
                position = new Vector3(-60,5,0);
                yRotation = UnityEngine.Random.Range(30, 150);
                break;
            case 3:
                position = new Vector3(60,5,0);
                yRotation = UnityEngine.Random.Range(-150, -30);
                break;
        }

        Quaternion rotation = Quaternion.Euler(0, yRotation, 0);

        Instantiate(EnemyPrefab, position, rotation);

    }


}
