using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletDamage = 5; // Damage done by the bullet
    
    void OnTriggerEnter2D(Collider2D other)
{
    EnemyHealth enemy = other.GetComponent<EnemyHealth>(); // Get the Enemy component of the collided object

    if (enemy != null) // Check if the collided object is an enemy
    {
        
        enemy.TakeDamage(bulletDamage); // Subtract enemy health
        Destroy(gameObject); // Destroy the bullet
    }
}
}
