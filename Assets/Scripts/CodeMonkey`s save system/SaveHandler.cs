using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using UnityEngine.SceneManagement;
public class SaveHandler : MonoBehaviour
{

    private List<ISaveable> saveable;



    void Awake()
    {

        this.saveable = FindAllSavebleObjects();

        SaveSystem.Init();
        Load();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F5))
        {
            Save();
        }
        if (Input.GetKeyDown(KeyCode.F9))
        {
            Load();
        }
    }
    public void NewGame()
    {

        SceneManager.LoadScene("TestingGamePlayMechanicsScene");
    }
    public void ContinueGame()
    {


    }
    private List<ISaveable> FindAllSavebleObjects()
    {
        IEnumerable<ISaveable> saveable = FindObjectsOfType<MonoBehaviour>()
            .OfType<ISaveable>();

        return new List<ISaveable>(saveable);
    }

    


    public void Save()
    {

        // Transform position=unit.GetPosition();
        // int health = unit.GethpAmount();
        SaveObject saveObject = new SaveObject
        {
            // hp=health,
            // playerPosition=position,
        };
        foreach (ISaveable dataPersistenceObj in saveable)
        {
            dataPersistenceObj.SaveData(saveObject);
        }
        string json = JsonUtility.ToJson(saveObject);
        SaveSystem.Save(json);

        Debug.Log("SAVE?");
        Debug.Log(json);
        // Debug.Log(position);
    }
    public void Load()
    {
        string saveString = SaveSystem.Load();
        if (saveString != null)
        {

            SaveObject saveObject = JsonUtility.FromJson<SaveObject>(saveString);
            foreach (ISaveable save in saveable)
            {
                save.LoadData(saveObject);
            }
        }




        else
        {
            Debug.Log("No Save");
            Debug.Log(saveString);
        }
    }
}
[Serializable]
public class SaveObject
{
    public int hp;
    public Vector3 playerPosition;
    public Quaternion playerRotation;
    //public static List<FooClass> barList = new List<FooClass>();

    public int amountOfAssaultRifleClips;
    public int amountOfKeys;
    public int amountOfMedpacks;
    public int amountOfPistolClips;
    public int amountOfShotgunClips;
    public bool isRiflePicked = false;
    public bool isShotGunPicked = false;
    public bool isPileOfLootPicked_R3;
    public int selectedWeapon;
    public bool isBigClownDead;
    public bool isBigCrawlerDead;
   

    public bool isGameLoaded;
}
// [Serializable]
//  public class FooClass
// {
//     public int Index { get; set; }

//     public string Name { get; set; }
// }



