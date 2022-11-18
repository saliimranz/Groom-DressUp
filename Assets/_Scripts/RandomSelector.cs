using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomSelector : MonoBehaviour
{
    private Image image;
    public Sprite[] spriteArray;
    int rand;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        rand = Random.Range(0, spriteArray.Length - 1);
        image.sprite = spriteArray[rand];
        image.SetNativeSize();    
    }

}
