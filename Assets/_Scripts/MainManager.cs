using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;
    public int SpriteInt;
    public int regionSelect;

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
    }

    public void SaveSpriteInt()
    {
        saveData AvatarSprite = new saveData();
        AvatarSprite.SpriteInt = SpriteInt;

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
        }
    }
}
