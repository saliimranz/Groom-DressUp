using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTM_SA : MonoBehaviour
{
    public GameObject[] SA_Shoes;
    public GameObject[] SA_Sherwani;
    public GameObject[] SA_Pants;
    public GameObject[] SA_Turban;
    public GameObject[] SA_Cape;

    // Start is called before the first frame update
    void Start()
    {
        AlreadyBought_Shirt();
        AlreadyBought_Shoes();
        AlreadyBought_Pants();
        AlreadyBought_Turban();
        AlreadyBought_Cape();

    }
    public void AlreadyBought_Shirt()
    {
        for (int i = 0; i < SA_Sherwani.Length; i++)
        {
            if (MainManager.Instance.allDress[i + 6] == true)
                SA_Sherwani[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }
    public void AlreadyBought_Shoes()
    {
        for (int i = 0; i < SA_Shoes.Length; i++)
        {
            if (MainManager.Instance.allShoes[i + 6] == true)
                SA_Shoes[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }
    public void AlreadyBought_Pants()
    {
        for (int i = 0; i < SA_Pants.Length; i++)
        {
            if (MainManager.Instance.allPants[i + 3] == true)
                SA_Pants[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }
    public void AlreadyBought_Turban()
    {
        for (int i = 0; i < SA_Turban.Length; i++)
        {
            if (MainManager.Instance.allHead[i + 6] == true)
                SA_Turban[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }
    public void AlreadyBought_Cape()
    {
        for (int i = 0; i < SA_Cape.Length; i++)
        {
            if (MainManager.Instance.SA_cape[i] == true)
                SA_Cape[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
