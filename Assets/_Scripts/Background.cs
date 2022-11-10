using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    public Sprite[] BackgroundsArray;
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        ChooseBackground();
    }

    private void ChooseBackground()
    {
        int i = Random.Range(0, (BackgroundsArray.Length - 1));
        image.sprite = BackgroundsArray[i];
    }

}
