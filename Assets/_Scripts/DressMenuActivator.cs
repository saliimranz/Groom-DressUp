using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressMenuActivator : MonoBehaviour
{
    public GameObject[] regions;
    private int selected;
    void Start()
    {
        selected = MainManager.Instance.regionSelect;
        MenuActivationMethod();
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
