using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private Slider slider;
    public int maxHealth = 100;
    public int currentHealth;
    public GameObject[] itemsToDrop;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateSlider();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        Debug.Log("I BEEN SHOT");
        UpdateSlider();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void UpdateSlider()
    {
        if (slider != null)
        {
            slider.value = (float)currentHealth / maxHealth;
        }
    }

    void Die()
    {
        // Destroy the enemy GameObject
        Destroy(gameObject);

        // Drop a random item from the array
        if (itemsToDrop.Length > 0)
        {
            int randomIndex = Random.Range(0, itemsToDrop.Length);
            Instantiate(itemsToDrop[randomIndex], transform.position, Quaternion.identity);
        }
    }
}
