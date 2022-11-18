using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comaparison : MonoBehaviour
{
    private Transform parent;
    public GameObject[] regions;
    private int selected;
    void Start()
    {
        parent = GetComponent<Transform>();
        selected = MainManager.Instance.regionSelect;
        MenuActivationMethod();
    }

    public void MenuActivationMethod()
    {
        GameObject CompareTo = regions[selected];
        //regions[selected].SetActive(true);
        GameObject regionComp = Instantiate(CompareTo, CompareTo.transform.position, Quaternion.identity) as GameObject;
        regionComp.transform.SetParent(parent, false);
        regionComp.SetActive(true);
    }
}
