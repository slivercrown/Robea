using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterInfo4 : MonoBehaviour
{

    //체력 4짜리

    GameObject monster;

    public static MonsterInfo4 instance;

    public int monsterhp = 4;

    void Start()
    {
        this.monster = GameObject.Find("monster");

        MonsterInfo4.instance = this;
    }

    public int Monhp()
    {

        return monsterhp;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
