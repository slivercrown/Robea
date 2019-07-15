using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//벽돌 몬스터 
public class MonsterInfo3 : MonoBehaviour
{
    GameObject monster;

    public static MonsterInfo3 instance;

    public int monsterhp = 3;


    void Start()
    {
        this.monster = GameObject.Find("monster");

        MonsterInfo3.instance = this;
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
