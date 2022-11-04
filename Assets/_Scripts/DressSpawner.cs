using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DressSpawner : MonoBehaviour
{
    public Sprite[] ItemSpawn;
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.sprite = ItemSpawn[MainManager.Instance.itemTransfer];
    }

    public void ApplyOnClick()
    {
        image.sprite = ItemSpawn[MainManager.Instance.itemTransfer];
    }
}
