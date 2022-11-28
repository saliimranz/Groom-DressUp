using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTM_ME : MonoBehaviour
{
    public GameObject[] ME_Thawab;
    public GameObject[] ME_Shoes;
    public GameObject[] ME_Kefiyeh;
    // Start is called before the first frame update
    void Start()
    {
        AlreadyBought_Thawab();
        AlreadyBought_Shoes();
        AlreadyBought_Keffiyeh();
    }
    public void AlreadyBought_Thawab()
    {
        for(int i = 0; i < ME_Thawab.Length; i++)
        {
            if(MainManager.Instance.allDress[i] == true)
                ME_Thawab[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }
    public void AlreadyBought_Shoes()
    {
        for (int i = 0; i < ME_Shoes.Length; i++)
        {
            if (MainManager.Instance.allShoes[i] == true)
                ME_Shoes[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }
    public void AlreadyBought_Keffiyeh()
    {
        for (int i = 0; i < ME_Kefiyeh.Length; i++)
        {
            if (MainManager.Instance.allHead[i] == true)
                ME_Kefiyeh[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
