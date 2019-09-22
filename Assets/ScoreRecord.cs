using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ScoreRecord : MonoBehaviour
{

    GameObject score;
    GameObject bestscore;
    public int nowscore;
    public int bscore;   // 이전 게임과 이번 게임의 값중 큰 값

    public int savedscore;
    

    public string temp3 = "bscore";
    public string temp0 = "savedscore";

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
        savedscore = PlayerPrefs.GetInt(temp0, 0);


        ScoreRecord.instance = this;    

        this.score.GetComponent<Text>().text = "score : " + nowscore.ToString("F0");

        this.bestscore.GetComponent<Text>().text = "bestscore : " + bscore.ToString("F0");

    }


    public void record()
    {
        nowscore = this.nowscore + MonsterInfo.instance.monsterhp;
        this.score.GetComponent<Text>().text = "score : " + nowscore.ToString("F0");

        savedscore = nowscore;


        if (bscore > nowscore)
        {
           this.bestscore.GetComponent<Text>().text = "bestscore : " + bscore.ToString("F0");
        }


        if (bscore <= nowscore)
        {
            bscore = nowscore;
            this.bestscore.GetComponent<Text>().text = "bestscore : " + bscore.ToString("F0");
            PlayerPrefs.SetInt(temp3, bscore);
        }
        
 
    }

    public void record2()
    {
        nowscore = this.nowscore + MonsterInfo2.instance.monsterhp;
        this.score.GetComponent<Text>().text = "score : " + nowscore.ToString("F0");

        savedscore = nowscore;

        if (bscore > nowscore)
        {
            this.bestscore.GetComponent<Text>().text = "bestscore : " + bscore.ToString("F0");
        }


        if (bscore <= nowscore)
        {
            bscore = nowscore;
            this.bestscore.GetComponent<Text>().text = "bestscore : " + bscore.ToString("F0");
            PlayerPrefs.SetInt(temp3, bscore);
        }
        

    }

    public void record4()
    {
        nowscore = this.nowscore + MonsterInfo4.instance.monsterhp;
        this.score.GetComponent<Text>().text = "score : " + nowscore.ToString("F0");

        savedscore = nowscore;

        if (bscore > nowscore)
        {
            this.bestscore.GetComponent<Text>().text = "bestscore : " + bscore.ToString("F0");
        }


        if (bscore <= nowscore)
        {
            bscore = nowscore;
            this.bestscore.GetComponent<Text>().text = "bestscore : " + bscore.ToString("F0");
            PlayerPrefs.SetInt(temp3, bscore);
        }


    }

    public void record3()
    {
        nowscore = this.nowscore + CoinInfo.instance.scoreup;
        this.score.GetComponent<Text>().text = "score : " + nowscore.ToString("F0");

        savedscore = nowscore;

        if (bscore > nowscore)
        {
            this.bestscore.GetComponent<Text>().text = "bestscore : " + bscore.ToString("F0");
        }


        if (bscore <= nowscore)
        {
            bscore = nowscore;
            this.bestscore.GetComponent<Text>().text = "bestscore : " + bscore.ToString("F0");
            PlayerPrefs.SetInt(temp3, bscore);
        }


    }

    public void record5()
    {
        nowscore = this.nowscore + MonsterInfo3.instance.monsterhp;
        this.score.GetComponent<Text>().text = "score : " + nowscore.ToString("F0");

        savedscore = nowscore;

        if (bscore > nowscore)
        {
            this.bestscore.GetComponent<Text>().text = "bestscore : " + bscore.ToString("F0");
        }


        if (bscore <= nowscore)
        {
            bscore = nowscore;
            this.bestscore.GetComponent<Text>().text = "bestscore : " + bscore.ToString("F0");
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

    public int result3()
    {
        savedscore = nowscore;
        PlayerPrefs.SetInt(temp0, savedscore);
        return savedscore;
    }


    void Update()
    {
        

    }
}
