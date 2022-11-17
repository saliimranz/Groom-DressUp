using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
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
}
