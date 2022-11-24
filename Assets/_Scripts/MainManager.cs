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

    public bool[] allDress = new bool[9];  //1st three ME -> W -> SA
    public bool[] allShoes = new bool[9];
    public bool[] allHead = new bool[9];

    public bool[] allPants = new bool[6];

    //----Western Remaining
    public bool[] WestTie = new bool[3]; 
    public bool[] WestCoat = new bool[3];
    //----SAsia Remaining
    public bool[] SA_cape = new bool[3];

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
        public bool[] allDress = new bool[9];  //1st three ME -> W -> SA
        public bool[] allShoes = new bool[9];
        public bool[] allHead = new bool[9];

        public bool[] allPants = new bool[6];
        //----Western Remaining
        public bool[] WestTie = new bool[3];
        public bool[] WestCoat = new bool[3];
        //----SAsia Remaining
        public bool[] SA_cape = new bool[3];

    }

    public void SaveSpriteInt()
    {
        saveData AvatarSprite = new saveData();
        AvatarSprite.SpriteInt = SpriteInt;
        AvatarSprite.MoneyLeft = MoneyLeft;
        // ------------ saving bool array ------------
        for(int i = 0; i < allDress.Length; i++)
        {
            AvatarSprite.allDress[i] = allDress[i];
        }
        for (int i = 0; i < allShoes.Length; i++)
        {
            AvatarSprite.allShoes[i] = allShoes[i];
        }
        for (int i = 0; i < allHead.Length; i++)
        {
            AvatarSprite.allHead[i] = allHead[i];
        }
        for (int i = 0; i < allPants.Length; i++)
        {
            AvatarSprite.allPants[i] = allPants[i];
        }

        //remaining west
        for (int i = 0; i < WestTie.Length; i++)
        {
            AvatarSprite.WestTie[i] = WestTie[i];
        }
        for (int i = 0; i < WestCoat.Length; i++)
        {
            AvatarSprite.WestCoat[i] = WestCoat[i];
        }

        // remaing SA
        for (int i = 0; i < SA_cape.Length; i++)
        {
            AvatarSprite.SA_cape[i] = SA_cape[i];
        }
        //--------------------------------------------

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


            // ------------ saving bool array ------------
            for (int i = 0; i < allDress.Length; i++)
            {
                allDress[i] = AvatarSprite.allDress[i] ;
            }
            for (int i = 0; i < allShoes.Length; i++)
            {
                allShoes[i] = AvatarSprite.allShoes[i];
            }
            for (int i = 0; i < allHead.Length; i++)
            {
                allHead[i] = AvatarSprite.allHead[i];
            }
            for (int i = 0; i < allPants.Length; i++)
            {
                allPants[i] = AvatarSprite.allPants[i];
            }
            //remaining west
            for (int i = 0; i < WestTie.Length; i++)
            {
                WestTie[i] = AvatarSprite.WestTie[i];
            }
            for (int i = 0; i < WestCoat.Length; i++)
            {
                WestCoat[i] = AvatarSprite.WestCoat[i];
            }

            // remaing SA
            for (int i = 0; i < SA_cape.Length; i++)
            {
                SA_cape[i] = AvatarSprite.SA_cape[i];
            }
            //--------------------------------------------
        }
    }
}
