using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private float maxHealth = 100f;
    [SerializeField] private float currentHealth;
    [SerializeField] private GameObject[] itemsToDrop;
    [SerializeField]private TextMeshProUGUI enemyCountText;
    [SerializeField]private ItemCount itemCount;
    
    void Start()
    {
        currentHealth = maxHealth;
        enemyCountText = GameObject.FindGameObjectWithTag("Text").GetComponent<TextMeshProUGUI>();
        itemCount=GameObject.FindGameObjectWithTag("Inventory").GetComponent<ItemCount>();
        enemyCountText.SetText("Количество убитых врагов  "+ itemCount.enemyCount);
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
            // float fillAmount = currentHealth / maxHealth;
            slider.value = currentHealth/maxHealth;
        }
    }
    // Function to update the enemy's health
 
    void Update(){
       UpdateSlider();
        // Position the health bar above the enemy's head
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        slider.transform.position = screenPos + new Vector3(0, 25, 0); // Adjusting the offset
    }
    void Die()
    {
        
        
        
        enemyCountText.SetText("Количество убитых врагов  "+ itemCount.enemyCount);
        // Destroy the enemy GameObject
        Destroy(gameObject);

        // Drop a random item from the array
        if (itemsToDrop.Length > 0)
        {
            int randomIndex = Random.Range(0, itemsToDrop.Length);
            Instantiate(itemsToDrop[randomIndex], transform.position, Quaternion.identity);
        }
        itemCount.enemyCount++;
    }

    
}
