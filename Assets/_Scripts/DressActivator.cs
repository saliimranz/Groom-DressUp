using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DressActivator : MonoBehaviour
{
    public GameObject[] DressLine;
    private int selected;
    // Start is called before the first frame update
    void Start()
    {
        selected = MainManager.Instance.regionSelect;
        MenuActivationMethod();
    }

    public void MenuActivationMethod()
    {
        DressLine[selected].SetActive(true);
    }
    public void MenuDeaactivate()
    {
        DressLine[selected].SetActive(false);
    }

}
