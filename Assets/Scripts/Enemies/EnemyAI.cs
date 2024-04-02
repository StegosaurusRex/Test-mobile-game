using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]private int maxHealth = 50;
    [SerializeField]private int currentHealth;
    [SerializeField]private Transform playerTransform;
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float attackRange = 3f;
    [SerializeField] private AudioClip attackSound;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private int damage;
    private float nextAttackTime = 0f;
    public float attackCooldown = 3f;

    public float minDistance = 5f; // Minimum distance for the enemy to start moving towards the player

    void Start()
    {
        currentHealth = maxHealth;
        playerTransform = GameObject.FindWithTag("Player").transform;
        audioSource = GetComponent<AudioSource>();
        playerHealth = playerTransform.GetComponent<PlayerHealth>();
    }

void Update()
    {

        AttackPlayer();
        if (playerTransform != null)
        {
            float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

            if (distanceToPlayer <= minDistance)
            {
                Vector3 direction = (playerTransform.position - transform.position).normalized;
                transform.Translate(direction * movementSpeed * Time.deltaTime);
            }
        }
    }
    
    void AttackPlayer()
{
    if (Time.time >= nextAttackTime)
    {
        if (Vector3.Distance(transform.position, playerTransform.position) <= attackRange)
        {
            // Perform attack action here (e.g., deal damage to player)
            playerHealth.TakeDamage(damage);
            Debug.Log("Attacking player!");

            // Play attack sound
            if (attackSound != null)
            {
                audioSource.PlayOneShot(attackSound);
            }

            nextAttackTime = Time.time + attackCooldown;
        }
    }
    // void TakeDamage(int damage)
    // {
    //     currentHealth -= damage;
    //     // Обновление полосы здоровья
    //     if (currentHealth <= 0)
    //     {
    //         Die();
    //     }
    }

    void Die()
    {
        // Действия при смерти монстра
        Debug.Log("Monster died");
        // Спаун предмета после смерти
    }
}
