using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnpPosZ = 30;
    private float startDelay = 1;
    private float spawnInterval = 1f;
    private float rightSpawnX = 25;
    private float rightSpawnZS = 15.0f;
    private float rightSpawnZE = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {

        int animalIndex = Random.Range(0, animalPrefabs.Length);

        var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnpPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandom_Animal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnpPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

        ////

        var spawnPosRight = new Vector3(-rightSpawnX, 0, Random.Range(rightSpawnZS, rightSpawnZE));
        Instantiate(animalPrefabs[animalIndex], spawnPosRight, animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 90, 0));

        animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 270, 0);



        ////
        var spawnPosleft = new Vector3(rightSpawnX, 0, Random.Range(rightSpawnZS, rightSpawnZE));
        Instantiate(animalPrefabs[animalIndex], spawnPosleft, animalPrefabs[animalIndex].transform.rotation);


        animalPrefabs[animalIndex].transform.rotation = Quaternion.Euler(0, 180, 0);
    }
}
