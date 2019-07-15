using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//검정 슬라임

public class MonsterInfo2 : MonoBehaviour
{
    GameObject monster;

    public static MonsterInfo2 instance;

    public int monsterhp = 1;

    public int monsterhp2 = 2;

    void Start()
    {
        this.monster = GameObject.Find("monster");

        MonsterInfo2.instance = this;
    }

    public int Monhp()
    {
        if (ScoreRecord.instance.nowscore > 50)
        {
            monsterhp = 2;

            return monsterhp;
        }

        else
        {
            return monsterhp;
        }
    }
    


    // Update is called once per frame
    void Update()
    {

    }
}
