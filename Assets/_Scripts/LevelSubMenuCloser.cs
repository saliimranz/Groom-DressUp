using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSubMenuCloser : MonoBehaviour
{
    public GameObject[] subMenu;
    int activated;

    public void SubMenuActivate(int SubIndex)
    {
        subMenu[SubIndex].SetActive(true);
        activated = SubIndex;
    } 
    public void DeactivateOthers()
    {
        for(int i = 0; i <= (subMenu.Length-1); i++)
        {
            if (i != activated)
            {
                subMenu[i].SetActive(false);
            }
        }
    }

    public void SendItemNum(int ItemToSpawn)
    {
        MainManager.Instance.itemTransfer = ItemToSpawn;
    }
}
