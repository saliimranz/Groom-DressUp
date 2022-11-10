using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsRecived : MonoBehaviour
{
    private Text coins;
    // Start is called before the first frame update
    void Start()
    {
        coins = GetComponent<Text>();
        coins.text = ("+"+MainManager.Instance.CoinsRecived+" Coins").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
