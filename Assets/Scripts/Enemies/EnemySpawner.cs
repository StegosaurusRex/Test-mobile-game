using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{   
    [SerializeField] private GameObject[] monsterPrefabs;
[SerializeField] private int numberOfMonsters = 3;
[SerializeField] private Camera mainCamera;
private Vector2 screenBounds;

void Start()
{
    mainCamera = Camera.main;
    screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));

    for (int i = 0; i < numberOfMonsters; i++)
    {
        int randomIndex = Random.Range(0, monsterPrefabs.Length);
        
        // Calculate random spawn position within screen bounds
        Vector3 spawnPosition = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y), 0);

        Instantiate(monsterPrefabs[randomIndex], spawnPosition, Quaternion.identity);
    }
}}
