using UnityEngine;
using System.IO;

public static class SavingDataSystem 
{
   static string savePath = Application.persistentDataPath + "/Savefile.json."
    public static void Save()
     {
        string json = JsonUtility.ToJson(Stats.userStats, true);
        File.writeAlltext(savePath, json);
        Debug.Log("Guardado en: " + savePath);
     }

     public static void Load()
     {
        if(File.Exists(savePath))
        {
            string json = file.ReadAllText(savePath);
            stats.userStats = JsonUtility.From<UserStats>(json);
            Debug.Log("Datos cargados");
        }
        else
        {
        {
         Debug.Log("No hay datos guardados")
        }
     }
}
