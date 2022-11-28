using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public static bool audioController = true;
    // Start is called before the first frame update
    public PlayAudio instance;
    public AudioSource audioSource;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
    }
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        audioSource.Play();     
    }

    public void MuteOrNot()
    {
        if (MainManager.Instance.audioBool)
        {
            audioSource.mute = false;

        }
        else if (!MainManager.Instance.audioBool)
        {
            audioSource.mute = true;
        }
    }
}
