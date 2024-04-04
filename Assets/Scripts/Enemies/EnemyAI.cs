using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    [SerializeField]private Transform playerTransform;
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private float attackRange = 3f;
    [SerializeField] private AudioClip attackSound;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private PlayerHealth playerHealth;
    [SerializeField] private int damage;
    [SerializeField] private float nextAttackTime = 0f;
    [SerializeField] private float attackCooldown = 3f;

    [SerializeField] private float minDistance = 5f; // Minimum distance for the enemy to start moving towards the player

    void Start()
    {

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

}
}