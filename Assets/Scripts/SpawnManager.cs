using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xPosRange = 22;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 3.0f, 1.5f);
    }

    void Update()
    {
        
    }

    void SpawnRandomAnimal()
    {
        float randXPos = Random.Range(-xPosRange, xPosRange);
        int animalPrefabIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 randPos = new Vector3(randXPos, 0, 21);
        Instantiate(animalPrefabs[animalPrefabIndex], randPos,
            animalPrefabs[animalPrefabIndex].transform.rotation);
    }

}
