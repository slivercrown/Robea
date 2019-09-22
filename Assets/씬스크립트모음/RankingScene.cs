using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class RankingScene : MonoBehaviour
{
    GameObject content1;
    GameObject content2;
    GameObject content3;
    GameObject content4;
    GameObject content5;
    GameObject content6;
    GameObject content7;
    GameObject content8;
    GameObject content9;
    GameObject content10;

    public static RankingScene instance;

    public int save;

    public int yrecord1 =0;
    public int yrecord2 =0;
    public int yrecord3 =0;
    public int yrecord4 =0;
    public int yrecord5 =0;
    public int yrecord6 =0;
    public int yrecord7 =0;
    public int yrecord8 =0;
    public int yrecord9 =0;
    public int yrecord10 =0;
    

    public int ybrecord; 

    public string save0 = "ybrecord";

    public string save1 = "yrecord1";
    public string save2 = "yrecord2";
    public string save3 = "yrecord3";
    public string save4 = "yrecord4";
    public string save5 = "yrecord5";
    public string save6 = "yrecord6";
    public string save7 = "yrecord7";
    public string save8 = "yrecord8";
    public string save9 = "yrecord9";
    public string save10 = "yrecord10";

    void Awake()
    {
        yrecord1 = PlayerPrefs.GetInt(save1, 0);
        yrecord2 = PlayerPrefs.GetInt(save2, 0);
        yrecord3 = PlayerPrefs.GetInt(save3, 0);
        yrecord4 = PlayerPrefs.GetInt(save4, 0);
        yrecord5 = PlayerPrefs.GetInt(save5, 0);
        yrecord6 = PlayerPrefs.GetInt(save6, 0);
        yrecord7 = PlayerPrefs.GetInt(save7, 0);
        yrecord8 = PlayerPrefs.GetInt(save8, 0);
        yrecord9 = PlayerPrefs.GetInt(save9, 0);
        yrecord10 = PlayerPrefs.GetInt(save10, 0);

        ybrecord = PlayerPrefs.GetInt(save0, 0);
    }



    void Start()
    {
        this.content1 = GameObject.Find("content1");
        this.content2 = GameObject.Find("content2");
        this.content3 = GameObject.Find("content3");
        this.content4 = GameObject.Find("content4");
        this.content5 = GameObject.Find("content5");
        this.content6 = GameObject.Find("content6");
        this.content7 = GameObject.Find("content7");
        this.content8 = GameObject.Find("content8");
        this.content9 = GameObject.Find("content9");
        this.content10 = GameObject.Find("content10");

        RankingScene instance = this;
        
        this.content1.GetComponent<Text>().text = "1 : " + yrecord1.ToString("F0");
        this.content2.GetComponent<Text>().text = "2 : " + yrecord2.ToString("F0");
        this.content3.GetComponent<Text>().text = "3 : " + yrecord3.ToString("F0");
        this.content4.GetComponent<Text>().text = "4 : " + yrecord4.ToString("F0");
        this.content5.GetComponent<Text>().text = "5 : " + yrecord5.ToString("F0");
        this.content6.GetComponent<Text>().text = "6 : " + yrecord6.ToString("F0");
        this.content7.GetComponent<Text>().text = "7 : " + yrecord7.ToString("F0");
        this.content8.GetComponent<Text>().text = "8 : " + yrecord8.ToString("F0");
        this.content9.GetComponent<Text>().text = "9 : " + yrecord9.ToString("F0");
        this.content10.GetComponent<Text>().text = "10 : " + yrecord10.ToString("F0");
        
  
        ybrecord = ScoreRecord.instance.result();
        PlayerPrefs.SetInt(save0, ybrecord);
        Debug.Log(ybrecord);

        if (ybrecord >= yrecord1)
        {


            yrecord10 = yrecord9;
            yrecord9 = yrecord8;
            yrecord8 = yrecord7;
            yrecord7 = yrecord6;
            yrecord6 = yrecord5;
            yrecord5 = yrecord4;
            yrecord4 = yrecord3;
            yrecord3 = yrecord2;
            yrecord2 = yrecord1;
            yrecord1 = ybrecord;

            this.content1.GetComponent<Text>().text = "1 : " + yrecord1.ToString("F0");
            this.content2.GetComponent<Text>().text = "2 : " + yrecord2.ToString("F0");
            this.content3.GetComponent<Text>().text = "3 : " + yrecord3.ToString("F0");
            this.content4.GetComponent<Text>().text = "4 : " + yrecord4.ToString("F0");
            this.content5.GetComponent<Text>().text = "5 : " + yrecord5.ToString("F0");
            this.content6.GetComponent<Text>().text = "6 : " + yrecord6.ToString("F0");
            this.content7.GetComponent<Text>().text = "7 : " + yrecord7.ToString("F0");
            this.content8.GetComponent<Text>().text = "8 : " + yrecord8.ToString("F0");
            this.content9.GetComponent<Text>().text = "9 : " + yrecord9.ToString("F0");
            this.content10.GetComponent<Text>().text = "10 : " + yrecord10.ToString("F0");

            
            PlayerPrefs.SetInt(save1, yrecord1);
            PlayerPrefs.SetInt(save2, yrecord2);
            PlayerPrefs.SetInt(save3, yrecord3);
            PlayerPrefs.SetInt(save4, yrecord4);
            PlayerPrefs.SetInt(save5, yrecord5);
            PlayerPrefs.SetInt(save6, yrecord6);
            PlayerPrefs.SetInt(save7, yrecord7);
            PlayerPrefs.SetInt(save8, yrecord8);
            PlayerPrefs.SetInt(save9, yrecord9);
            PlayerPrefs.SetInt(save10, yrecord10);


        }

        if (ybrecord < yrecord1 && ybrecord >= yrecord2)
        {
            yrecord10 = yrecord9;
            yrecord9 = yrecord8;
            yrecord8 = yrecord7;
            yrecord7 = yrecord6;
            yrecord6 = yrecord5;
            yrecord5 = yrecord4;
            yrecord4 = yrecord3;
            yrecord3 = yrecord2;
            yrecord2 = ybrecord;


            this.content2.GetComponent<Text>().text = "2 : " + yrecord2.ToString("F0");
            this.content3.GetComponent<Text>().text = "3 : " + yrecord3.ToString("F0");
            this.content4.GetComponent<Text>().text = "4 : " + yrecord4.ToString("F0");
            this.content5.GetComponent<Text>().text = "5 : " + yrecord5.ToString("F0");
            this.content6.GetComponent<Text>().text = "6 : " + yrecord6.ToString("F0");
            this.content7.GetComponent<Text>().text = "7 : " + yrecord7.ToString("F0");
            this.content8.GetComponent<Text>().text = "8 : " + yrecord8.ToString("F0");
            this.content9.GetComponent<Text>().text = "9 : " + yrecord9.ToString("F0");
            this.content10.GetComponent<Text>().text = "10 : " + yrecord10.ToString("F0"); this.content2.GetComponent<Text>().text = "2 : " + yrecord2.ToString("F0");

            PlayerPrefs.SetInt(save2, yrecord2);
            PlayerPrefs.SetInt(save3, yrecord3);
            PlayerPrefs.SetInt(save4, yrecord4);
            PlayerPrefs.SetInt(save5, yrecord5);
            PlayerPrefs.SetInt(save6, yrecord6);
            PlayerPrefs.SetInt(save7, yrecord7);
            PlayerPrefs.SetInt(save8, yrecord8);
            PlayerPrefs.SetInt(save9, yrecord9);
            PlayerPrefs.SetInt(save10, yrecord10);

        }
            
        if(ybrecord < yrecord2 && ybrecord >= yrecord3)
        {
            yrecord10 = yrecord9;
            yrecord9 = yrecord8;
            yrecord8 = yrecord7;
            yrecord7 = yrecord6;
            yrecord6 = yrecord5;
            yrecord5 = yrecord4;
            yrecord4 = yrecord3;
            yrecord3 = ybrecord;

            this.content3.GetComponent<Text>().text = "3 : " + yrecord3.ToString("F0");
            this.content4.GetComponent<Text>().text = "4 : " + yrecord4.ToString("F0");
            this.content5.GetComponent<Text>().text = "5 : " + yrecord5.ToString("F0");
            this.content6.GetComponent<Text>().text = "6 : " + yrecord6.ToString("F0");
            this.content7.GetComponent<Text>().text = "7 : " + yrecord7.ToString("F0");
            this.content8.GetComponent<Text>().text = "8 : " + yrecord8.ToString("F0");
            this.content9.GetComponent<Text>().text = "9 : " + yrecord9.ToString("F0");
            this.content10.GetComponent<Text>().text = "10 : " + yrecord10.ToString("F0"); 

            
            PlayerPrefs.SetInt(save3, yrecord3);
            PlayerPrefs.SetInt(save4, yrecord4);
            PlayerPrefs.SetInt(save5, yrecord5);
            PlayerPrefs.SetInt(save6, yrecord6);
            PlayerPrefs.SetInt(save7, yrecord7);
            PlayerPrefs.SetInt(save8, yrecord8);
            PlayerPrefs.SetInt(save9, yrecord9);
            PlayerPrefs.SetInt(save10, yrecord10);
        }

        if (ybrecord < yrecord3 && ybrecord >= yrecord4)
        {
            yrecord10 = yrecord9;
            yrecord9 = yrecord8;
            yrecord8 = yrecord7;
            yrecord7 = yrecord6;
            yrecord6 = yrecord5;
            yrecord5 = yrecord4;
            yrecord4 = ybrecord;

            
            this.content4.GetComponent<Text>().text = "4 : " + yrecord4.ToString("F0");
            this.content5.GetComponent<Text>().text = "5 : " + yrecord5.ToString("F0");
            this.content6.GetComponent<Text>().text = "6 : " + yrecord6.ToString("F0");
            this.content7.GetComponent<Text>().text = "7 : " + yrecord7.ToString("F0");
            this.content8.GetComponent<Text>().text = "8 : " + yrecord8.ToString("F0");
            this.content9.GetComponent<Text>().text = "9 : " + yrecord9.ToString("F0");
            this.content10.GetComponent<Text>().text = "10 : " + yrecord10.ToString("F0");


            
            PlayerPrefs.SetInt(save4, yrecord4);
            PlayerPrefs.SetInt(save5, yrecord5);
            PlayerPrefs.SetInt(save6, yrecord6);
            PlayerPrefs.SetInt(save7, yrecord7);
            PlayerPrefs.SetInt(save8, yrecord8);
            PlayerPrefs.SetInt(save9, yrecord9);
            PlayerPrefs.SetInt(save10, yrecord10);
        }

        if (ybrecord < yrecord4 && ybrecord >= yrecord5)
        {
            yrecord10 = yrecord9;
            yrecord9 = yrecord8;
            yrecord8 = yrecord7;
            yrecord7 = yrecord6;
            yrecord6 = yrecord5;
            yrecord5 = ybrecord;

            this.content5.GetComponent<Text>().text = "5 : " + yrecord5.ToString("F0");
            this.content6.GetComponent<Text>().text = "6 : " + yrecord6.ToString("F0");
            this.content7.GetComponent<Text>().text = "7 : " + yrecord7.ToString("F0");
            this.content8.GetComponent<Text>().text = "8 : " + yrecord8.ToString("F0");
            this.content9.GetComponent<Text>().text = "9 : " + yrecord9.ToString("F0");
            this.content10.GetComponent<Text>().text = "10 : " + yrecord10.ToString("F0");


            PlayerPrefs.SetInt(save5, yrecord5);
            PlayerPrefs.SetInt(save6, yrecord6);
            PlayerPrefs.SetInt(save7, yrecord7);
            PlayerPrefs.SetInt(save8, yrecord8);
            PlayerPrefs.SetInt(save9, yrecord9);
            PlayerPrefs.SetInt(save10, yrecord10);
        }

        if (ybrecord < yrecord5 && ybrecord >= yrecord6)
        {
            yrecord10 = yrecord9;
            yrecord9 = yrecord8;
            yrecord8 = yrecord7;
            yrecord7 = yrecord6;
            yrecord6 = ybrecord;

            this.content6.GetComponent<Text>().text = "6 : " + yrecord6.ToString("F0");
            this.content7.GetComponent<Text>().text = "7 : " + yrecord7.ToString("F0");
            this.content8.GetComponent<Text>().text = "8 : " + yrecord8.ToString("F0");
            this.content9.GetComponent<Text>().text = "9 : " + yrecord9.ToString("F0");
            this.content10.GetComponent<Text>().text = "10 : " + yrecord10.ToString("F0");

            
            PlayerPrefs.SetInt(save6, yrecord6);
            PlayerPrefs.SetInt(save7, yrecord7);
            PlayerPrefs.SetInt(save8, yrecord8);
            PlayerPrefs.SetInt(save9, yrecord9);
            PlayerPrefs.SetInt(save10, yrecord10);
        }

        if (ybrecord < yrecord6 && ybrecord >= yrecord7)
        {
            yrecord10 = yrecord9;
            yrecord9 = yrecord8;
            yrecord8 = yrecord7;
            yrecord7 = ybrecord;

            this.content7.GetComponent<Text>().text = "7 : " + yrecord7.ToString("F0");
            this.content8.GetComponent<Text>().text = "8 : " + yrecord8.ToString("F0");
            this.content9.GetComponent<Text>().text = "9 : " + yrecord9.ToString("F0");
            this.content10.GetComponent<Text>().text = "10 : " + yrecord10.ToString("F0");

            
            PlayerPrefs.SetInt(save7, yrecord7);
            PlayerPrefs.SetInt(save8, yrecord8);
            PlayerPrefs.SetInt(save9, yrecord9);
            PlayerPrefs.SetInt(save10, yrecord10);
        }

        if (ybrecord < yrecord7 && ybrecord >= yrecord8)
        {
            yrecord10 = yrecord9;
            yrecord9 = yrecord8;
            yrecord8 = ybrecord;

            this.content8.GetComponent<Text>().text = "8 : " + yrecord8.ToString("F0");
            this.content9.GetComponent<Text>().text = "9 : " + yrecord9.ToString("F0");
            this.content10.GetComponent<Text>().text = "10 : " + yrecord10.ToString("F0");

            
            PlayerPrefs.SetInt(save8, yrecord8);
            PlayerPrefs.SetInt(save9, yrecord9);
            PlayerPrefs.SetInt(save10, yrecord10); 
        }

        if (ybrecord < yrecord8 && ybrecord >= yrecord9)
        {
            yrecord10 = yrecord9;
            yrecord9 = ybrecord;

            this.content9.GetComponent<Text>().text = "9 : " + yrecord9.ToString("F0");
            this.content10.GetComponent<Text>().text = "10 : " + yrecord10.ToString("F0");


            
            PlayerPrefs.SetInt(save9, yrecord9);
            PlayerPrefs.SetInt(save10, yrecord10); 
        }

        if (ybrecord < yrecord9 && ybrecord >= yrecord10)
        {
            yrecord10 = ybrecord;

            PlayerPrefs.SetInt(save10, yrecord10);

            this.content10.GetComponent<Text>().text = "10 : " + yrecord10.ToString("F0");
            PlayerPrefs.SetInt(save10, yrecord10);
        }

    }


    public void BButtonDown()
    {
        SceneManager.LoadScene("StartScene2");
    }

    void Update()
    {
        
    }
}
