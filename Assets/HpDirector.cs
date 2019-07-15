using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HpDirector : MonoBehaviour
{
    
    

    public GameObject player;
    public GameObject Monster;
    public GameObject playerhp;
    public GameObject weaponhp;

    public int nowhp;
    public int duration;
    public int k;
    public int r;
    

    public static HpDirector instance;


     void Start()
    {
        this.player = GameObject.Find("player");
        this.Monster = GameObject.Find("Monster");
        this.playerhp = GameObject.Find("playerhp");
        this.weaponhp = GameObject.Find("weaponhp");

        HpDirector.instance = this;

        this.nowhp = 10;
        this.duration = 0;
        this.playerhp.GetComponent<Text>().text = "체력 : " + this.nowhp.ToString("F0");
        this.weaponhp.GetComponent<Text>().text = "무기공격력 : " + this.duration.ToString("F0");

    }

    public void Update()
    {
        
    }
   


    // Update is called once per frame
    public void DecreaseHp() {

        k = this.duration - MonsterInfo.instance.Monhp();

        if (k >= 0)
        {
            duration = k;

        }
        else
        {
            duration = 0;
            nowhp = k + this.nowhp;
        }
        

        this.playerhp.GetComponent<Text>().text = "체력 : " + nowhp.ToString("F0");
        this.weaponhp.GetComponent<Text>().text = "무기공격력 : " + this.duration.ToString("F0");


        if (nowhp > 10)
        {
            nowhp = 10;
        }

        if (nowhp <= 0)
        {
            
            SceneManager.LoadScene("EndScene");
        }
    }

    public void DecreaseHp2()
    {

        k = this.duration - MonsterInfo2.instance.Monhp();
        
        if(k>=0)
        {
            duration = k;
            
        }
        else
        {
            duration = 0;
            nowhp = k + this.nowhp;
        }
       
        
        this.playerhp.GetComponent<Text>().text = "체력 : " + nowhp.ToString("F0");
        this.weaponhp.GetComponent<Text>().text = "무기공격력 : " + this.duration.ToString("F0");

        if (nowhp > 10)
        {
            nowhp = 10;
        }

        if (nowhp <= 0)
        {
            
            SceneManager.LoadScene("EndScene");
        }

       
    }

    public void DecreaseHp3()
    {

        k = this.duration - MonsterInfo3.instance.Monhp();

        if (k >= 0)
        {
            duration = k;

        }
        else
        {
            duration = 0;
            nowhp = k + this.nowhp;
        }


        this.playerhp.GetComponent<Text>().text = "체력 : " + nowhp.ToString("F0");
        this.weaponhp.GetComponent<Text>().text = "무기공격력 : " + this.duration.ToString("F0");

        if (nowhp > 10)
        {
            nowhp = 10;
        }

        if (nowhp <= 0)
        {

            SceneManager.LoadScene("EndScene");
        }


    }

    public void DecreaseHp4()
    {

        k = this.duration - MonsterInfo4.instance.Monhp();

        if (k >= 0)
        {
            duration = k;

        }
        else
        {
            duration = 0;
            nowhp = k + this.nowhp;
        }


        this.playerhp.GetComponent<Text>().text = "체력 : " + nowhp.ToString("F0");
        this.weaponhp.GetComponent<Text>().text = "무기공격력 : " + this.duration.ToString("F0");

        if (nowhp > 10)
        {
            nowhp = 10;
        }

        if (nowhp <= 0)
        {

            SceneManager.LoadScene("EndScene");
        }


    }

    public void UpHp()
    {
        nowhp = this.nowhp + PotionInfo.instance.Up();

        if (nowhp > 10)
        { 
        nowhp = 10;
        }

        this.playerhp.GetComponent<Text>().text = "체력 : " + nowhp.ToString("F0");
     }

    public void DownHp()
    {
        nowhp = this.nowhp + PotionInfo2.instance.Down();

        if(nowhp <=0)
        {
            SceneManager.LoadScene("EndScene");
        }

        this.playerhp.GetComponent<Text>().text = "체력 : " + nowhp.ToString("F0");
    }


    public void Duration()
    {
        duration = this.duration + WeaponInfo.instance.Dur();

        if(duration > 4)
        {
            duration = 4;
        }
        
    
        this.playerhp.GetComponent<Text>().text = "체력 : " + nowhp.ToString("F0");

        this.weaponhp.GetComponent<Text>().text = "무기공격력 : " + this.duration.ToString("F0");
    }


}

//