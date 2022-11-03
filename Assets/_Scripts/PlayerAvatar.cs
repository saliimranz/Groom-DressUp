using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAvatar : MonoBehaviour
{
    public Sprite[] playerAva;
    private Image image;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
        image.sprite = playerAva[MainManager.Instance.SpriteInt];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
