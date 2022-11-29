using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class _DressSpawnerME : MonoBehaviour
{

    List<Sprite[]> arrayList = new List<Sprite[]>();
    int arraySelected;
    bool submitActivate;
    public GameObject submitButton;
    public GameObject storePannel;

    public Sprite[] Shoes;
        public Sprite[] Thawab;
        public Sprite[] Keffiyeh; 

    private Image image;

    void Start()
    {
        arrayList.Add(Thawab);
        arrayList.Add(Shoes);
        arrayList.Add(Keffiyeh);
    }
    private void Update()
    {
        if (!submitActivate)
            submitButton.SetActive(false);
    }

    public void ApplyOnClick(bool paid)
    {
       
        if (paid)
        {
            //-----------------------Checking Item Type and bool----------------------------------------
            if(MainManager.Instance.ItemSelected == 0)
            {
                if (MainManager.Instance.allDress[MainManager.Instance.itemTransfer - 5] == true)
                {
                    goto Continue;
                }
            }
            else if(MainManager.Instance.ItemSelected == 1)
            {
                if (MainManager.Instance.allShoes[MainManager.Instance.itemTransfer - 5] == true)
                {
                    goto Continue;
                }
            }
            else if(MainManager.Instance.ItemSelected == 2)
            {
                if (MainManager.Instance.allHead[MainManager.Instance.itemTransfer - 5] == true)
                {
                    goto Continue;
                }
            }
            //---------------------Getting Button Details-------------------------------------------------
            Button btn = EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
            GameObject PriceBar = btn.transform.GetChild(1).gameObject;
            Text stringPrice = PriceBar.transform.GetChild(0).GetComponent<Text>();
            int  price = int.Parse(stringPrice.text);

            if (price > MainManager.Instance.MoneyLeft)
            {
                storePannel.SetActive(true);
                return;
            }
            else if(price <= MainManager.Instance.MoneyLeft)
            {
                MainManager.Instance.MoneyLeft -= price;
                btn.transform.GetChild(1).gameObject.SetActive(false);

                setMainBool();
                MainManager.Instance.SaveSpriteInt();
            }
        }
        Continue:
        arraySelected = MainManager.Instance.ItemSelected;
        image = gameObject.transform.GetChild(arraySelected).GetComponent<Image>();

        image.sprite = arrayList[arraySelected][MainManager.Instance.itemTransfer];
        submitActivate = true;
    }

    public void setMainBool()
    {
        if(MainManager.Instance.ItemSelected == 0)
        {
            MainManager.Instance.allDress[MainManager.Instance.itemTransfer - 5] = true;
        }
        else if (MainManager.Instance.ItemSelected == 1)
        {
            MainManager.Instance.allShoes[MainManager.Instance.itemTransfer - 5] = true;
        }
        else if (MainManager.Instance.ItemSelected == 2)
        {
            MainManager.Instance.allHead[MainManager.Instance.itemTransfer - 5] = true;
        }
    }
}
