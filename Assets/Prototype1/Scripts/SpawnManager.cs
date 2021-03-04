using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyprefab;
    public GameObject PowerupPrefab;

    private float spawnRange = 9;
    public int enemycount;
    public int waveCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPowerups();
        spawnEnemywave(waveCount);
    }
    // Update is called once per frame
    void Update()
    {
        enemycount = FindObjectsOfType<EnemyController>().Length;
        if (enemycount == 0)
        {
            waveCount++;
            spawnEnemywave(waveCount);
            SpawnPowerups();

        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }

    void spawnEnemywave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyprefab, GenerateSpawnPosition(), enemyprefab.transform.rotation);
        }
    }

    void SpawnPowerups()
    {
        Instantiate(PowerupPrefab, GenerateSpawnPosition(), PowerupPrefab.transform.rotation);
    }

}
