using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCount : MonoBehaviour, ISaveable
{
    [SerializeField] public int item1Count;
    [SerializeField] public int item2Count;
    [SerializeField] public int item3Count;
   [SerializeField] public int item4Count;
    [SerializeField] public int item5Count;
    [SerializeField] public int item6Count;
    public int enemyCount;
    [SerializeField] private GameObject item1WithTag;
    [SerializeField] private GameObject item2WithTag;
    [SerializeField] private GameObject item3WithTag;
    [SerializeField] private GameObject item4WithTag;
    [SerializeField] private GameObject item5WithTag;
    [SerializeField] private GameObject item6WithTag;

    public void LoadData(SaveObject data)
    {
        this.enemyCount = data.enemyCount;
    }

    public void SaveData(SaveObject data)
    {
        data.enemyCount=this.enemyCount;
    }
    // Start is called before the first frame update

}
