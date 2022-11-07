using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressMenuActivator : MonoBehaviour
{
    private Transform parent;
    public GameObject[] regions;
    private int selected;
    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.Find("SideMenuBar-Panel").transform;
        selected = MainManager.Instance.regionSelect;
        MenuActivationMethod();
    }

    public void MenuActivationMethod()
    {
        GameObject ArrayMenuSelected = regions[selected];
       // regions[selected].SetActive(true);

        GameObject newMenu = Instantiate(ArrayMenuSelected, ArrayMenuSelected.transform.position, Quaternion.identity) as GameObject;
        newMenu.SetActive(true);
        newMenu.transform.SetParent(parent, false); // So the position is in world cordinates not parent's
    } 
    public void MenuDeaactivate()
    {
        regions[selected].SetActive(false);
    }
}
