using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public static class SaveSystem
{
    public static readonly string SAVE_FOLDER = Application.persistentDataPath + "/Saves/";
    public static void Init()
    {
        if (!Directory.Exists(SAVE_FOLDER))
        {
            Directory.CreateDirectory(SAVE_FOLDER);
            
        }

    }
    public static void Save(string saveString)
    {
        // int saveNumber=1;
        // while (File.Exists(SAVE_FOLDER+"save_"+saveNumber+".json")){
        //     saveNumber++;
        // }
        File.WriteAllText(SAVE_FOLDER + "save_" + ".json", saveString);
    }

    public static string Load()
    {
        DirectoryInfo directoryInfo = new DirectoryInfo(SAVE_FOLDER);
        FileInfo[] saveFiles = directoryInfo.GetFiles("*.json");
        FileInfo mostRecentFile = null;
        foreach (FileInfo fileInfo in saveFiles)
        {
            if (mostRecentFile == null)
            {
                mostRecentFile = fileInfo;
            }
            else
            {
                if (fileInfo.LastWriteTime > mostRecentFile.LastWriteTime)
                {
                    mostRecentFile = fileInfo;
                }
            }
        }
        if (mostRecentFile != null)
        {
            string saveString = File.ReadAllText(mostRecentFile.FullName);
            return saveString;
        }
        else
        {
            return null;
        }


    }

    public static void DeleteSaveFile(string fileName)
    {
        if (File.Exists(SAVE_FOLDER + fileName))
        {
            File.Delete(SAVE_FOLDER + fileName);
        }
    }

    public static bool CheckSaveFile(string fileName)
    {
        
        if (File.Exists(SAVE_FOLDER + fileName))
        {
            return true;
        }
        else { return false; }
    }
}