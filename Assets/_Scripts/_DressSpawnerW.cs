using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _DressSpawnerW : MonoBehaviour
{
    List<Sprite[]> arrayList = new List<Sprite[]>();
    int arraySelected;

    public Sprite[] Shirt;
    public Sprite[] Pant;
    public Sprite[] Shoes;
    public Sprite[] Hair;
    public Sprite[] Tie;
    public Sprite[] Coat;

    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        arrayList.Add(Shirt);
        arrayList.Add(Pant);
        arrayList.Add(Shoes);
        arrayList.Add(Hair);
        arrayList.Add(Tie);
        arrayList.Add(Coat);
    }
    public void ApplyOnClick()
    {
        arraySelected = MainManager.Instance.ItemSelected;
        image = gameObject.transform.GetChild(arraySelected).GetComponent<Image>();

        image.sprite = arrayList[arraySelected][MainManager.Instance.itemTransfer];
    }
}
