using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OppAnim : MonoBehaviour
{
    public Image opponent;
    public Image oppflag;

    public Sprite[] avatar;
    public Sprite[] flag;
    
    int randIndex;
    bool doNow;
    
    // Start is called before the first frame update
    void Start()
    {
        doNow = true;
        StartCoroutine(CloseNow());
    }

    IEnumerator CloseNow()
    {
        yield return new WaitForSeconds(3f);
        doNow = false;
        savetoMain();
    }

    // Update is called once per frame
    void Update()
    {
        if(doNow)
        {
            randIndex = Random.Range(0, (avatar.Length-1));
            opponent.sprite = avatar[randIndex];
            oppflag.sprite = flag[randIndex];
        }
          
    }

    void savetoMain()
    {
        MainManager.Instance.OppSelected = randIndex;
    }
}
