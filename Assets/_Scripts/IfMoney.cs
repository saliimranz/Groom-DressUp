using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfMoney : MonoBehaviour
{
    int price = 6000;
    int MoneyLeft = 8000;
    public Button btn;
    // Start is called before the first frame update
    void Start()
    { 
            btn.interactable = false;
    }

    // Update is called once per frame
    void Update()
    {
               
    }
    private void OnMouse()
    {
        if(price <= MoneyLeft)
        {
            btn.interactable = true;
            MoneyLeft -= price;
            Debug.Log(MoneyLeft);
            btn.transform.GetChild(1).gameObject.SetActive(false);
            
        }
    }

}
