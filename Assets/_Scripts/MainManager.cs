using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public int SpriteInt;
    public int MoneyLeft;
    public int OppSelected;

    public int regionSelect;
    public int itemTransfer;
    public int ItemSelected;
    public int CoinsRecived;

    public bool[,] MEastArray = new bool[3, 3];
    public bool[,] WestArray = new bool[6,3];
    public bool[,] SAsiaArray = new bool[5,3];
    

    public void Awake()
    {
        if (Instance != null )
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

        LoadSpriteInt();
    }

    [System.Serializable]
    class saveData
    {
        public int SpriteInt;
        public int MoneyLeft;
        public bool[,] MEastArray = new bool[3, 3];
        public bool[,] WestArray = new bool[6, 3];
        public bool[,] SAsiaArray = new bool[5, 3];
    }

    public void SaveSpriteInt()
    {
        saveData AvatarSprite = new saveData();
        AvatarSprite.SpriteInt = SpriteInt;
        AvatarSprite.MoneyLeft = MoneyLeft;
        
        
        for (int i = 0; i < AvatarSprite.MEastArray.GetLength(0); i++)
        {
            for (int j = 0; j < AvatarSprite.MEastArray.GetLength(1); j++)
            {
                AvatarSprite.MEastArray[i, j] = MEastArray[i, j];
                Debug.Log(AvatarSprite.MEastArray[i, j] + " ----> saved in json---> " + MEastArray[i, j]);
            }
        }
       

        for (int i = 0; i < AvatarSprite.WestArray.GetLength(0); i++)
        {
            for (int j = 0; j < AvatarSprite.WestArray.GetLength(1); j++)
            {
                AvatarSprite.WestArray[i, j] = WestArray[i, j];
            }
        }
        
        for (int i = 0; i < AvatarSprite.SAsiaArray.GetLength(0); i++)
        {
            for (int j = 0; j < AvatarSprite.SAsiaArray.GetLength(1); j++)
            {
                AvatarSprite.SAsiaArray[i, j] = SAsiaArray[i, j];
            }
        }

        string json = JsonUtility.ToJson(AvatarSprite);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadSpriteInt()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            saveData AvatarSprite = JsonUtility.FromJson<saveData>(json);

            SpriteInt = AvatarSprite.SpriteInt;
            MoneyLeft = AvatarSprite.MoneyLeft;

            for (int i = 0; i < MEastArray.GetLength(0); i++)
            {
              
                for (int j = 0; j < MEastArray.GetLength(1); j++)
                {
                    Debug.Log(MEastArray.GetLength(1));
                    MEastArray[i, j] = AvatarSprite.MEastArray[i, j];

                    Debug.Log(MEastArray[i, j] +"----> getting from saved----> " + AvatarSprite.MEastArray[i, j]);
                }
            }


            for (int i = 0; i < WestArray.GetLength(0); i++)
            {
                for (int j = 0; j < WestArray.GetLength(1); j++)
                {
                    WestArray[i, j] = AvatarSprite.WestArray[i, j];  
                }
            }

            for (int i = 0; i < SAsiaArray.GetLength(0); i++)
            {
                for (int j = 0; j < SAsiaArray.GetLength(1); j++)
                {
                    SAsiaArray[i, j] = AvatarSprite.SAsiaArray[i, j];
                }
            }
        }
    }
}
