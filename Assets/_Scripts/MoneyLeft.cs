using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyLeft : MonoBehaviour
{
    private Text Money;
    int MoneyInt;
    // Start is called before the first frame update
    void Start()
    {
        Money = GetComponent<Text>();

        MoneyInt = MainManager.Instance.MoneyLeft;
        Money.text = MoneyInt.ToString();
    }

}
