using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressActivator : MonoBehaviour
{
    private Transform parent;
    public GameObject[] DressLine;
    private int selected;
    // Start is called before the first frame update
    void Start()
    {
        parent = GameObject.Find("Avatar-To-Dress").transform;
        selected = MainManager.Instance.regionSelect;
        MenuActivationMethod();
    }

    public void MenuActivationMethod()
    {
        GameObject ArrayMenuSelected = DressLine[selected];
        // regions[selected].SetActive(true);

        GameObject newMenu = Instantiate(ArrayMenuSelected, ArrayMenuSelected.transform.position, Quaternion.identity) as GameObject;
        newMenu.SetActive(true);
        newMenu.transform.SetParent(parent, false);
    }
    public void MenuDeaactivate()
    {
        DressLine[selected].SetActive(false);
    }

}
