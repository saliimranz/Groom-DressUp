using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _DressSpawnerME : MonoBehaviour
{

    List<Sprite[]> arrayList = new List<Sprite[]>();
    int arraySelected; 

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

    public void ApplyOnClick(bool paid)
    {
       
        if (paid)
        {
            if (MainManager.Instance.MEastArray[MainManager.Instance.ItemSelected, MainManager.Instance.itemTransfer - 5] == true)
            {
                goto Continue;
            }
            Button btn = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
            GameObject PriceBar = btn.transform.GetChild(1).gameObject;
            Text stringPrice = PriceBar.transform.GetChild(0).GetComponent<Text>();
            int  price = int.Parse(stringPrice.text);

            if (price > MainManager.Instance.MoneyLeft)
            {
                return;
            }
            else if(price <= MainManager.Instance.MoneyLeft)
            {
                MainManager.Instance.MoneyLeft -= price;
                btn.transform.GetChild(1).gameObject.SetActive(false);

                MainManager.Instance.MEastArray[MainManager.Instance.ItemSelected, MainManager.Instance.itemTransfer - 5] = true;
                MainManager.Instance.SaveSpriteInt();
            }
        }
        Continue:
        arraySelected = MainManager.Instance.ItemSelected;
        image = gameObject.transform.GetChild(arraySelected).GetComponent<Image>();

        image.sprite = arrayList[arraySelected][MainManager.Instance.itemTransfer];
    }
}
