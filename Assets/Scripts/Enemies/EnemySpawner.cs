using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{   
    [SerializeField] private GameObject[] monsterPrefabs;
[SerializeField] private int numberOfMonsters = 3;
[SerializeField] private Camera mainCamera;
[SerializeField] private Vector2 screenBounds;
[SerializeField] private float spawnWaveTime;

void Start()
{
    mainCamera = Camera.main;
    screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
    //StartCoroutine(SpawnMonsters());
    SpawnEnemyWave();
}
void SpawnEnemyWave(){
    for (int i = 0; i < numberOfMonsters; i++)
    {
        int randomIndex = Random.Range(0, monsterPrefabs.Length);
        
        // Calculate random spawn position within screen bounds
        Vector3 spawnPosition = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y), 0);

        Instantiate(monsterPrefabs[randomIndex], spawnPosition, Quaternion.identity);
    }
}
private IEnumerator SpawnMonsters()
{
    while (true)
    {
        for (int i = 0; i < numberOfMonsters; i++)
        {
            int randomIndex = Random.Range(0, monsterPrefabs.Length);

            // Calculate random spawn position within screen bounds
            Vector3 spawnPosition = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y), 0);

            Instantiate(monsterPrefabs[randomIndex], spawnPosition, Quaternion.identity);
        }

        yield return new WaitForSeconds(spawnWaveTime); // Wait for 15 seconds before spawning monsters again
    }
}
}
