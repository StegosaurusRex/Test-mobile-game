using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{   
    [SerializeField] private GameObject[] monsterPrefabs;
    [SerializeField] private int numberOfMonsters = 3;

    void Start()
    {
        for (int i = 0; i < numberOfMonsters; i++)
        {
            int randomIndex = Random.Range(0, 1);
            Vector3 spawnPosition = new Vector3(Random.Range(45f, 62f), Random.Range(7f, 14f), 0);
            Instantiate(monsterPrefabs[randomIndex], spawnPosition, Quaternion.identity);
        }
    }
}
