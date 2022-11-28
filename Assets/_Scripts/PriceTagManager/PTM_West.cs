using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PTM_West : MonoBehaviour
{
    public GameObject[] West_Shoes;
    public GameObject[] West_Shirt;
    public GameObject[] West_Pants;
    public GameObject[] Hairs;
    public GameObject[] Tie;
    public GameObject[] Coat;

    // Start is called before the first frame update
    void Start()
    {
        AlreadyBought_Shirt();
        AlreadyBought_Shoes();
        AlreadyBought_Pants();
        AlreadyBought_Hairs();
        AlreadyBought_Tie();
        AlreadyBought_Coat();
    }
    public void AlreadyBought_Shirt()
    {
        for (int i = 0; i < West_Shirt.Length; i++)
        {
            if (MainManager.Instance.allDress[i + 3] == true)
                West_Shirt[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }
    public void AlreadyBought_Shoes()
    {
        for (int i = 0; i < West_Shoes.Length; i++)
        {
            if (MainManager.Instance.allShoes[i+3] == true)
                West_Shoes[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }
    public void AlreadyBought_Pants()
    {
        for (int i = 0; i < West_Pants.Length; i++)
        {
            if (MainManager.Instance.allPants[i] == true)
                West_Pants[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }
    public void AlreadyBought_Hairs()
    {
        for (int i = 0; i < Hairs.Length; i++)
        {
            if (MainManager.Instance.allHead[i+3] == true)
                Hairs[i+3].transform.GetChild(1).gameObject.SetActive(false);
        }
    }

    public void AlreadyBought_Tie()
    {
        for (int i = 0; i < Tie.Length; i++)
        {
            if (MainManager.Instance.WestTie[i] == true)
                Tie[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }
    public void AlreadyBought_Coat()
    {
        for (int i = 0; i < Coat.Length; i++)
        {
            if (MainManager.Instance.WestCoat[i] == true)
                Coat[i].transform.GetChild(1).gameObject.SetActive(false);
        }
    }
}
