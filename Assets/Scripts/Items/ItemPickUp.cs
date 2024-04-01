using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
 void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Добавление предмета в инвентарь персонажа
            Debug.Log("Item picked up");
            Destroy(gameObject); // Уничтожение предмета после подбора
        }
    }
}
