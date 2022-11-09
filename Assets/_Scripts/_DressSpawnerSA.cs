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

    public void ApplyOnClick()
    {
        arraySelected = MainManager.Instance.ItemSelected;
        image = gameObject.transform.GetChild(arraySelected).GetComponent<Image>();

        image.sprite = arrayList[arraySelected][MainManager.Instance.itemTransfer];
    }
}
