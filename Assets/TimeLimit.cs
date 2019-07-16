using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLimit : MonoBehaviour
{
    GameObject timer;

    public static TimeLimit instance;

    public float limittime;

    private void Awake()
    {

        TimeLimit.instance = this;
        this.timer = GameObject.Find("timer");
        

    }

    void Start()
    {
        limittime = 60;
    }

    // Update is called once per frame
    void Update()
    {
        

        limittime -= Time.deltaTime;


        this.timer.GetComponent<Text>().text = ("timer : ") + Mathf.Round(SkillDirector.instance.TimeWind()) + "s";
        
       
        if(this.limittime <= 0)
        {
            SceneManager.LoadScene("EndScene");
        }

    }
}
