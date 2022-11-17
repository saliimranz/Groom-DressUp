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

    public void PaidItems()
    {
        btn =  UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
        Debug.Log(MoneyLeft);
        if (price <= MoneyLeft)
        {
            btn.interactable = true;
            MoneyLeft -= price;
            Debug.Log(MoneyLeft);
            btn.transform.GetChild(1).gameObject.SetActive(false);
        }
        else
        {
            btn.enabled = false;
            return;
        }
    }

    public void SendItemNum(int ItemToSpawn)
    {
        MainManager.Instance.itemTransfer = ItemToSpawn;
    }
}
