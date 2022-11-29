using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _DressSpawnerSA : MonoBehaviour
{
    List<Sprite[]> arrayList = new List<Sprite[]>();
    int arraySelected;
    bool submitActivate;
    public GameObject submitButton;
    public GameObject storePannel;

    public Sprite[] Sherwani;
    public Sprite[] Pants;
    public Sprite[] Shoes;
    public Sprite[] Turban;
    public Sprite[] Cape;

    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        arrayList.Add(Pants);
        arrayList.Add(Sherwani);
        arrayList.Add(Shoes);
        arrayList.Add(Turban);
        arrayList.Add(Cape);
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
            if (MainManager.Instance.ItemSelected == 0)
            {
                if (MainManager.Instance.allPants[MainManager.Instance.itemTransfer-2] == true)
                {
                    goto Continue;
                }
            }
            else if (MainManager.Instance.ItemSelected == 1)
            {
                if (MainManager.Instance.allDress[MainManager.Instance.itemTransfer + 1] == true)
                {
                    goto Continue;
                }
            }
            else if (MainManager.Instance.ItemSelected == 2)
            {
                if (MainManager.Instance.allShoes[MainManager.Instance.itemTransfer + 1] == true)
                {
                    goto Continue;
                }
            }
            else if (MainManager.Instance.ItemSelected == 3)
            {
                if (MainManager.Instance.allHead[MainManager.Instance.itemTransfer + 1] == true)
                {
                    goto Continue;
                }
            }
            else if (MainManager.Instance.ItemSelected == 4)
            {
                if (MainManager.Instance.SA_cape[MainManager.Instance.itemTransfer-5] == true)
                {
                    goto Continue;
                }
            }

            //---------------------Getting Button Details-------------------------------------------------

            Button btn = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
            GameObject PriceBar = btn.transform.GetChild(1).gameObject;
            Text stringPrice = PriceBar.transform.GetChild(0).GetComponent<Text>();
            int price = int.Parse(stringPrice.text);

            if (price > MainManager.Instance.MoneyLeft)
            {
                storePannel.SetActive(true);
                return;
            }
            else if (price <= MainManager.Instance.MoneyLeft)
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
        if (MainManager.Instance.ItemSelected == 0)
        {
            MainManager.Instance.allPants[MainManager.Instance.itemTransfer - 2] = true;
        }
        else if (MainManager.Instance.ItemSelected == 1)
        {
            MainManager.Instance.allDress[MainManager.Instance.itemTransfer + 1] = true;
            Debug.Log("Item bought is: " + MainManager.Instance.itemTransfer);
        }
        else if (MainManager.Instance.ItemSelected == 2)
        {
            MainManager.Instance.allShoes[MainManager.Instance.itemTransfer + 1] = true;
        }
        else if (MainManager.Instance.ItemSelected == 3)
        {
            MainManager.Instance.allHead[MainManager.Instance.itemTransfer + 1] = true;
        }
        else if (MainManager.Instance.ItemSelected == 4)
        {
            Debug.Log("MainMAnager Index ha: " + (MainManager.Instance.itemTransfer - 5));
            MainManager.Instance.SA_cape[MainManager.Instance.itemTransfer - 5] = true;
        }
    }
}
