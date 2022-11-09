using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSelector : MonoBehaviour
{
    public void OnClickOnButton(int region)
    {
        MainManager.Instance.regionSelect = region;
    }
}
