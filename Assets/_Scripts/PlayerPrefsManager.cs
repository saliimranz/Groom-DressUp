using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    const string MASTER_VOLUME_KEY = "master_volume";
    const string DIFFICULTY_KEY = "difficulty";
    const string LEVEL_KEY = "level_unlocked_";
    const string AVATAR_KEY = "avatar_no_";

    public static void SetMasterVolume(float volume)
    {
        if(volume > 0f && volume < 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
            Debug.LogError("Master Volume Out of range");
        }
    }

    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }

    public static void SetAvatarKey(int number)
    {
        if(number >= 0 && number <= 7)
        {
            PlayerPrefs.SetInt(AVATAR_KEY, number);
        }
        else
        {
            Debug.LogError("Avatar key out of range");
        }
    }

    public static int GetAvatarKey()
    {
        return PlayerPrefs.GetInt(AVATAR_KEY);
    }
}
