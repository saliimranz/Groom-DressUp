using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AvatarManager : MonoBehaviour
{
    public Sprite[] BannerSprite;
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.sprite = BannerSprite[MainManager.Instance.SpriteInt];
    }
    public void GetImageOnClick(int CountofAv)
    {
        MainManager.Instance.SpriteInt = CountofAv;
        MainManager.Instance.SaveSpriteInt();
        image.sprite = BannerSprite[CountofAv];
    }
}
