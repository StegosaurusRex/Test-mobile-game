using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]private int maxHealth = 50;
    [SerializeField]private int currentHealth;
    [SerializeField]private Transform playerTransform;
    [SerializeField] private float movementSpeed = 5f;

    void Start()
    {
        currentHealth = maxHealth;
        playerTransform = GameObject.FindWithTag("Player").transform;

    }

void Update()
    {
        if (playerTransform != null)
        {
            
                Vector3 direction = (playerTransform.position - transform.position).normalized;
                transform.position += direction * movementSpeed * Time.deltaTime;
            
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        // Обновление полосы здоровья
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // Действия при смерти монстра
        Debug.Log("Monster died");
        // Спаун предмета после смерти
    }
}
