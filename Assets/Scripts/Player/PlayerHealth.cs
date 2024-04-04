using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    [SerializeField]private float maxHealth = 100;
    [SerializeField]private float currentHealth;
[SerializeField] private Slider slider;
    void Start()
    {
        currentHealth = maxHealth;
        UpdateSlider();
    }
    void Update(){
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        slider.transform.position = screenPos + new Vector3(0, 60, 0); // Adjusting the offset
    }

    public void TakeDamage(int damage)
    {

        currentHealth -= damage;
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
    void Die()
    {
        // Действия при смерти персонажа
        Debug.Log("Player died");
        Destroy(gameObject);
    }
}
