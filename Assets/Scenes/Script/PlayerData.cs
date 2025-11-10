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

            UserData.playerName = playerName;
            UserData.playerMaxHealth = playerMaxHealth;
            UserData.playerMaxMana = playerMaxMana;
            UserData.playerExp = playerExp;
            UserData.playerPosition = playerPosition;

            
            Debug.Log("Data saved");

        }




        public void LoadData()
        {

            playerName = UserData.playerName;
            playerMaxHealth = UserData.playerMaxHealth;
            playerMaxMana = UserData.playerMaxMana;
            playerExp = UserData.playerExp;

            Debug.Log("Data loaded");

        }

        public void SavePrefs()
        {
            PlayerPrefs.SetString("Player Name", playerName);
            PlayerPrefs.SetInt("Player Health", playerMaxHealth);
            PlayerPrefs.SetInt("Player Mana", playerMaxMana);
            PlayerPrefs.SetInt("Player exp", playerExp);
        }





        public void LoadPrefs()
        {
            playerName = PlayerPrefs.GetString("Player Name");
            playerMaxHealth = PlayerPrefs.GetInt("Player Health", 1);
            playerMaxMana = PlayerPrefs.GetInt("Player Mana", 1);
            playerExp = PlayerPrefs.GetInt("Player exp", 1);
        }
        
}
