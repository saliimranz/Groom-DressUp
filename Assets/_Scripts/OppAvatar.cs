using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OppAvatar : MonoBehaviour
{
    public Image OppImage;
    public Sprite[] OppAva;
    // Start is called before the first frame update
    void Start()
    {
        OppImage.sprite = OppAva[MainManager.Instance.OppSelected];
    }

}
