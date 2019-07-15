using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreRecord : MonoBehaviour
{

    GameObject score;
    GameObject bestscore;
    public int nowscore;
    public int bscore;   // 이전 게임과 이번 게임의 값중 큰 값
    

    public string temp3 = "bscore";

    public static ScoreRecord instance;

    void Awake()
    {
        
    }


    void Start()
    {
        this.score = GameObject.Find("score");
        this.bestscore = GameObject.Find("bestscore");
        this.nowscore = 0;
        bscore = PlayerPrefs.GetInt(temp3,0);


        ScoreRecord.instance = this;    

        this.score.GetComponent<Text>().text = "점수 : " + nowscore.ToString("F0");

        this.bestscore.GetComponent<Text>().text = "최고점수 : " + bscore.ToString("F0");

    }


    public void record()
    {
        nowscore = this.nowscore + MonsterInfo.instance.monsterhp;
        this.score.GetComponent<Text>().text = "점수 : " + nowscore.ToString("F0");
        
        
        

        if (bscore > nowscore)
        {
           this.bestscore.GetComponent<Text>().text = "최고점수 : " + bscore.ToString("F0");
        }


        if (bscore <= nowscore)
        {
            bscore = nowscore;
            this.bestscore.GetComponent<Text>().text = "최고점수 : " + bscore.ToString("F0");
            PlayerPrefs.SetInt(temp3, bscore);
        }
        
 
    }

    public void record2()
    {
        nowscore = this.nowscore + MonsterInfo2.instance.monsterhp;
        this.score.GetComponent<Text>().text = "점수 : " + nowscore.ToString("F0");



        if (bscore > nowscore)
        {
            this.bestscore.GetComponent<Text>().text = "최고점수 : " + bscore.ToString("F0");
        }


        if (bscore <= nowscore)
        {
            bscore = nowscore;
            this.bestscore.GetComponent<Text>().text = "최고점수 : " + bscore.ToString("F0");
            PlayerPrefs.SetInt(temp3, bscore);
        }
        

    }

    public void record3()
    {
        nowscore = this.nowscore + CoinInfo.instance.scoreup;
        this.score.GetComponent<Text>().text = "점수 : " + nowscore.ToString("F0");



        if (bscore > nowscore)
        {
            this.bestscore.GetComponent<Text>().text = "최고점수 : " + bscore.ToString("F0");
        }


        if (bscore <= nowscore)
        {
            bscore = nowscore;
            this.bestscore.GetComponent<Text>().text = "최고점수 : " + bscore.ToString("F0");
            PlayerPrefs.SetInt(temp3, bscore);
        }


    }

    public int result()
    {
        return nowscore;
    }


    public int result2()
    {
        return bscore;
    }


    void Update()
    {
        

    }
}
