using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _DressSpawnerSA : MonoBehaviour
{
    List<Sprite[]> arrayList = new List<Sprite[]>();
    int arraySelected;

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

    public void ApplyOnClick(bool paid)
    {
        if (paid)
        {

            if (MainManager.Instance.SAsiaArray[MainManager.Instance.ItemSelected, MainManager.Instance.itemTransfer - 5] == true)
            {
                goto Continue;
            }

            Button btn = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.GetComponent<Button>();
            GameObject PriceBar = btn.transform.GetChild(1).gameObject;
            Text stringPrice = PriceBar.transform.GetChild(0).GetComponent<Text>();
            int price = int.Parse(stringPrice.text);

            if (price > MainManager.Instance.MoneyLeft)
            {
                return;
            }
            else if (price <= MainManager.Instance.MoneyLeft)
            {
                MainManager.Instance.MoneyLeft -= price;
                btn.transform.GetChild(1).gameObject.SetActive(false);

                MainManager.Instance.SAsiaArray[MainManager.Instance.ItemSelected, MainManager.Instance.itemTransfer - 5] = true;
                MainManager.Instance.SaveSpriteInt();
            }
        }

        Continue:
        arraySelected = MainManager.Instance.ItemSelected;
        image = gameObject.transform.GetChild(arraySelected).GetComponent<Image>();

        image.sprite = arrayList[arraySelected][MainManager.Instance.itemTransfer];
    }
}
