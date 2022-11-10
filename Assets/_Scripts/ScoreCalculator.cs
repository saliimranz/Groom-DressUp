using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCalculator : MonoBehaviour
{
    public GameObject winner;
    public GameObject loser;
    public LevelManager levelManager;

    public Text PlayerScore;
    public Text OpponentScore;
    public Text TypeOfScore;
    public Text P_ScoreProfile;
    public Text Opp_ScoreProfile;
    public Slider p_Slider;
    public Slider Opp_Slider;
    

    int p_Sum = 0;
    int Opp_Sum = 0;
    int i = 0;
    int p_avg;
    int Opp_avg;
    int coinsRecived;

    string[] ScoreType = { "Dress", "Face", "Extras" };
    
    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();
    }
    public void P_ScoreCal()
    {
        int score = Random.Range(5, 10);
        PlayerScore.text = score.ToString();
        p_Sum = p_Sum + score;

        P_ScoreProfile.text = ("Score: " + score).ToString();
        p_Slider.value = score ;
    }
    public void Opp_ScoreCal()
    {
        int score = Random.Range(5, 10);
        OpponentScore.text = score.ToString();
        Opp_Sum = Opp_Sum + score;

        Opp_ScoreProfile.text = ("Score: " + score).ToString();
        Opp_Slider.value = score;
    }

    public void TypeScore()
    {
        TypeOfScore.text = ScoreType[i].ToString();
        i++;
    }

    public void Final()
    {
        p_avg = p_Sum / 3;
        Opp_avg = Opp_Sum / 3;
        PlayerScore.text = (p_avg).ToString();
        OpponentScore.text = (Opp_avg).ToString();
        TypeOfScore.text = ("Final").ToString();

        P_ScoreProfile.text = ("Score: " + p_avg).ToString();
        p_Slider.value = p_avg;
        Opp_ScoreProfile.text = ("Score: " + Opp_avg).ToString();
        Opp_Slider.value = Opp_avg;
    }

    public void Decision()
    {
        StartCoroutine(LevelLoader());
    } 
    IEnumerator LevelLoader()
    {
        if (p_avg >= Opp_avg)
        {
            winner.SetActive(true);
            yield return new WaitForSeconds(3.5f);
            levelManager.LoadLevel("03a Win Scene");
            coinsRecived = Random.Range(100, 500);
            MainManager.Instance.CoinsRecived = coinsRecived;
            MainManager.Instance.MoneyLeft += coinsRecived;
            MainManager.Instance.SaveSpriteInt();
        }
        else if (Opp_avg > p_avg)
        {
            loser.SetActive(true);
            yield return new WaitForSeconds(3.5f);
            levelManager.LoadLevel("03b Lose scene");
        }
    }


    

}
