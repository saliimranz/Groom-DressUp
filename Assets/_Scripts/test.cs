using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Avatar Selected is: " + MainManager.Instance.SpriteInt);    
    }
}
