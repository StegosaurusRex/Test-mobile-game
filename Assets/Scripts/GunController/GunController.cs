using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Transform gun;
    public Transform player;
    public GameObject[] enemies;

    void Update()
    {
        if (enemies.Length > 0)
        {
            GameObject closestEnemy = FindClosestEnemy();
            Vector3 direction = closestEnemy.transform.position - gun.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            gun.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }

        // Rotate player sprite based on movement direction
        float moveDirection = Input.GetAxis("Horizontal");
        if (moveDirection < 0)
        {
            player.localScale = new Vector3(-1, 1, 1); // Flip sprite horizontally
        }
        else if (moveDirection > 0)
        {
            player.localScale = new Vector3(1, 1, 1); // Reset sprite scale
        }
    }

    GameObject FindClosestEnemy()
    {
        GameObject closestEnemy = null;
        float closestDistance = Mathf.Infinity;

        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(gun.position, enemy.transform.position);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy;
            }
        }

        return closestEnemy;
    }
}
