using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PriceTagManager : MonoBehaviour
{
    private GameObject tag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AlreadyBought()
    {
        tag = transform.GetChild(5).gameObject;
        tag.SetActive(false);
    }
}
