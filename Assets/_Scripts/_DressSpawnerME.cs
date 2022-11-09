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
   // private Image image;
    // Start is called before the first frame update
    void Start()
    {
        //image = GetComponent<Image>();
        arrayList.Add(Thawab);
        arrayList.Add(Shoes);
        arrayList.Add(Keffiyeh);
    }

    public void ApplyOnClick()
    {
        arraySelected = MainManager.Instance.ItemSelected;
        image = gameObject.transform.GetChild(arraySelected).GetComponent<Image>();

        image.sprite = arrayList[arraySelected][MainManager.Instance.itemTransfer];
    }
}
