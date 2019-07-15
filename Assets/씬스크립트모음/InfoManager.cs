using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InfoManager : MonoBehaviour
{

    GameObject minfo;
    GameObject minfo2;
    GameObject mimage;
    GameObject mimage2;

    public static InfoManager instance;


    void Start()
    {
        InfoManager.instance = this;
        this.minfo = GameObject.Find("minfo");
        this.minfo2 = GameObject.Find("minfo2");
        this.mimage = GameObject.Find("mimage");
        this.mimage2 = GameObject.Find("mimage2");

        this.minfo.GetComponent<Text>().text = "이블아이, 체력 : " + MonsterInfo.instance.Monhp().ToString("F0");
        this.minfo2.GetComponent<Text>().text = "블랙슬라임, 체력: " + MonsterInfo2.instance.Monhp().ToString("F0");

    }


    public void BButtonDown()
    {
        SceneManager.LoadScene("GameScene2");
    }
    
    public void info()
    {
        this.minfo.GetComponent<Text>().text = "이블아이, 체력 : " + MonsterInfo.instance.Monhp().ToString("F0");
        this.minfo2.GetComponent<Text>().text = "블랙슬라임, 체력: " + MonsterInfo2.instance.Monhp().ToString("F0");
    }
}
