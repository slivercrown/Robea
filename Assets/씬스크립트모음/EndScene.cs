using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScene : MonoBehaviour
{

    GameObject scorerecord;
    GameObject bestscore;
    GameObject deadcause;

    public static EndScene instance;
    

    void Start()
    {
        EndScene.instance = this;
        this.scorerecord = GameObject.Find("scorerecord");
        this.bestscore = GameObject.Find("bestscore");
        this.deadcause = GameObject.Find("deadcause");



        this.scorerecord.GetComponent<Text>().text = "점수 : " + ScoreRecord.instance.result().ToString("F0");
        this.bestscore.GetComponent<Text>().text = "최고점수 : " + ScoreRecord.instance.result2().ToString("F0");

        if(HpDirector.instance.nowhp <= 0)
        this.deadcause.GetComponent<Text>().text = "당신의 남은 체력이 0이 되어서 " +
                "사망하였습니다.";

        if (TimeLimit.instance.limittime <= 0)
            this.deadcause.GetComponent<Text>().text = "당신의 남은 시간이 0이 되어서 " +
                            "사망하였습니다.";
    }
    
    
    public void RButtonDown()
    {
        SceneManager.LoadScene("StartScene2");
    }



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
