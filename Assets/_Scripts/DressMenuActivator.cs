using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressMenuActivator : MonoBehaviour
{
    public GameObject[] regions;
    private int selected;
    // Start is called before the first frame update
    void Start()
    {
        selected = MainManager.Instance.regionSelect;
        MenuActivationMethod();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MenuActivationMethod()
    {
        regions[selected].SetActive(true);
    } 
    public void MenuDeaactivate()
    {
        regions[selected].SetActive(false);
    }
}
