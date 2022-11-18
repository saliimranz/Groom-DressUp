using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSubMenuCloser : MonoBehaviour
{
    int price = 16000;
    int MoneyLeft = 8000;
    public Button btn;

    public GameObject[] subMenu;
    private Button ClickedButton;
    int activated;

    public void SubMenuActivate(int SubIndex)
    {
        subMenu[SubIndex].SetActive(true);
        activated = SubIndex;
        MainManager.Instance.ItemSelected = SubIndex;
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
