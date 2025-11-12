using UnityEngine;

public class PlayerData : MonoBehaviour
{
   
  // public static PlayerData Instance;
   public string playerName;  
   
   public Vector3 playerPosition;
   
   public int playerMaxMana;
   
   public int playerMaxHealth;
   
   public int playerExp;

   /*void Awake()
   {
        //if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Destroy = this;
        }
        
        DontDestroyOnLoad(gameObject);
    }*/



        public void SaveData()
        {

            /*UserData.playerName = playerName;
            UserData.playerMaxHealth = playerMaxHealth;
            UserData.playerMaxMana = playerMaxMana;
            UserData.playerExp = playerExp;
            UserData.playerPosition = playerPosition;*/

            Stats.userStats.playerName = playerName;
            Stats.userStats.playerPosition = playerPosition;
            Stats.userStats.playerMaxHealth = playerMaxHealth;

            SavingDataSystem.Save();

            

            
           // Debug.Log("Data saved");

        }




        public void LoadData()
        {

           /* playerName = UserData.playerName;
            playerMaxHealth = UserData.playerMaxHealth;
            playerMaxMana = UserData.playerMaxMana;
            playerExp = UserData.playerExp;
            playerPosition = UserData.playerPosition;*/

            playerName = Stats.userStats.playerName;
            playerPosition = Stats.userStats.playerPosition;
            playerMaxHealth = Stats.userStats.playerMaxHealth;

           // Debug.Log("Data loaded");

           SavingDataSystem.Load();

        }

        public void SavePrefs()
        {
            PlayerPrefs.SetString("Player Name", playerName);
            PlayerPrefs.SetInt("Player Health", playerMaxHealth);
            PlayerPrefs.SetInt("Player Mana", playerMaxMana);
            PlayerPrefs.SetInt("Player exp", playerExp);
            PlayerPrefs.SetFloat("Player position", playerPosition.x);
            PlayerPrefs.SetFloat("Player position", playerPosition.y);
            PlayerPrefs.SetFloat("Player position", playerPosition.z);
        }





        public void LoadPrefs()
        {
            playerName = PlayerPrefs.GetString("Player Name");
            playerMaxHealth = PlayerPrefs.GetInt("Player Health", 1);
            playerMaxMana = PlayerPrefs.GetInt("Player Mana", 1);
            playerExp = PlayerPrefs.GetInt("Player exp", 1);
            playerPosition.x = PlayerPrefs.GetFloat("Player position", 0);
            playerPosition.y = PlayerPrefs.GetFloat("Player position", 0);
            playerPosition.z = PlayerPrefs.GetFloat("Player position", 0);
        }
        
}
