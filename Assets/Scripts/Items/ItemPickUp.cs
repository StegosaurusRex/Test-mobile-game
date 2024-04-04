using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemPickUp : MonoBehaviour
{
    [SerializeField] private AudioClip pickupSound; // Reference to the audio clip for pickup sound
    [SerializeField] private AudioSource audioSource; // Reference to the AudioSource component
    
    [SerializeField] private TextMeshProUGUI item1WithTagText;
    [SerializeField] private TextMeshProUGUI item2WithTagText;
    [SerializeField] private TextMeshProUGUI item3WithTagText;
    [SerializeField] private TextMeshProUGUI item4WithTagText;
    [SerializeField] private TextMeshProUGUI item5WithTagText;
    [SerializeField] private TextMeshProUGUI item6WithTagText;



    [SerializeField] private GameObject item1WithTag;
    [SerializeField] private GameObject item2WithTag;
    [SerializeField] private GameObject item3WithTag;
    [SerializeField] private GameObject item4WithTag;
    [SerializeField] private GameObject item5WithTag;
    [SerializeField] private GameObject item6WithTag;
     [SerializeField] private GameObject item1;
    [SerializeField] private GameObject item2;
    [SerializeField] private GameObject item3;
    [SerializeField] private GameObject item4;
    [SerializeField] private GameObject item5;
    [SerializeField] private GameObject item6;

    [SerializeField] private GridLayoutGroup inventoryGrid;
public enum ItemType
    {
        
        Item1,
        Item2,
        Item3,
        Item4,
        Item5,
        Item6,
        
    }
    public ItemType itemType;
    [SerializeField] private ItemCount itemCount;
    void Start()
    {
        inventoryGrid=GameObject.FindGameObjectWithTag("Inventory").GetComponent<GridLayoutGroup>();
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component attached to the same GameObject
        item1WithTag = GameObject.FindGameObjectWithTag("CreatedItem1");
        itemCount=GameObject.FindGameObjectWithTag("Inventory").GetComponent<ItemCount>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            switch (itemType)
        {
            case ItemType.Item1:
                
                item1WithTag = GameObject.FindGameObjectWithTag("CreatedItem1");
                if (item1WithTag!=null){
                    
                    item1WithTagText = item1WithTag.GetComponentInChildren<TextMeshProUGUI>();
                    itemCount.item1Count++;
                    item1WithTagText.SetText("" + itemCount.item1Count);
                    Debug.Log(itemCount.item1Count);
                    
                } else 
                    Instantiate(item1, inventoryGrid.transform);
                if (itemCount.item1Count==-1){
                    Destroy(item1WithTag);
                }
                break;
            case ItemType.Item2:
                
                item2WithTag = GameObject.FindGameObjectWithTag("CreatedItem2");
                if (item2WithTag!=null){
                    
                 item2WithTagText = item2WithTag.GetComponentInChildren<TextMeshProUGUI>();
                    itemCount.item2Count++;
                    item2WithTagText.SetText("" + itemCount.item2Count);
                    
                } else Instantiate(item2, inventoryGrid.transform);
                itemCount.item2Count++;
                break;
                case ItemType.Item3:
                
                item3WithTag = GameObject.FindGameObjectWithTag("CreatedItem3");
                if (item3WithTag!=null){
                    
                item3WithTagText = item3WithTag.GetComponentInChildren<TextMeshProUGUI>();
                    itemCount.item3Count++;
                    item3WithTagText.SetText("" + itemCount.item3Count);
                    
                } else Instantiate(item3, inventoryGrid.transform);
                itemCount.item3Count++;
                break;
                case ItemType.Item4:
                
                item4WithTag = GameObject.FindGameObjectWithTag("CreatedItem4");
                    
                if (item4WithTag!=null){
                    item4WithTagText = item4WithTag.GetComponentInChildren<TextMeshProUGUI>();
                    itemCount.item4Count++;
                    item4WithTagText.SetText("" + itemCount.item4Count);
                    
                } else Instantiate(item4, inventoryGrid.transform);
                itemCount.item4Count++;
                break;
                case ItemType.Item5:
                
                item5WithTag = GameObject.FindGameObjectWithTag("CreatedItem5");
                if (item5WithTag!=null){
                    
                item5WithTagText = item5WithTag.GetComponentInChildren<TextMeshProUGUI>();
                    itemCount.item5Count++;
                    item5WithTagText.SetText("" + itemCount.item5Count);
                    
                } else Instantiate(item5, inventoryGrid.transform);
                itemCount.item5Count++;
                break;
                case ItemType.Item6:
                
                item6WithTag = GameObject.FindGameObjectWithTag("CreatedItem6");
                if (item6WithTag!=null){
                    
                    item6WithTagText = item6WithTag.GetComponentInChildren<TextMeshProUGUI>();
                    itemCount.item6Count++;
                    item6WithTagText.SetText("" + itemCount.item6Count);
                    
                } else 
                    Instantiate(item6, inventoryGrid.transform);
                    itemCount.item6Count++;
                break;
            default:
                Debug.Log("Item with unknown tag added/removed");
                // Дополнительный код для обработки предметов с другими тегами
                break;
        }
            // Play the pickup sound
            if (pickupSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(pickupSound);
            }

            Debug.Log("Item picked up");
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Destroy(gameObject, 0.5f); // Destroy the item after picking it up
        }
    }
  
}


