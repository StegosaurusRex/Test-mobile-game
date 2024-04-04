using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    [SerializeField] private SaveHandler saveHandler;
    [SerializeField] private GameObject checkpointText;
   
    private float timer=0;
  
    
    void Start()
    {
        saveHandler = FindObjectOfType<SaveHandler>();
        
        
    
    }
   
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {

        
        
       
        if (other.gameObject.CompareTag("Player"))
        {

            // Call SaveHandler's Save method
            saveHandler.Save();
            checkpointText.SetActive(true);
            
            
        }

        
        
    }

    void OnTriggerExit(Collider other)
    {
        
            //Destroy checkpoint
            Destroy(this.gameObject);
        
    }
}
