using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMAnager : MonoBehaviour
{
    private PlayAudio playAudio;
    void Start()
    {
        if (MainManager.Instance.audioBool)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }else if (!MainManager.Instance.audioBool)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);

        }
    }
    public void soundController(bool btn)
    {
        playAudio = GameObject.Find("Load Sound").GetComponent<PlayAudio>();
        MainManager.Instance.audioBool = btn;
        playAudio.MuteOrNot();
        if(btn == false)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            gameObject.transform.GetChild(1).gameObject.SetActive(true);
            
        }
        else if (btn == true)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            gameObject.transform.GetChild(1).gameObject.SetActive(false);
        }     
    }
}
