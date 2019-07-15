using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//날개달린 눈알

public class MonsterInfo : MonoBehaviour
{
    GameObject monster;

    public static MonsterInfo instance;

    public int monsterhp = 2;
    

    void Start()
    {
        this.monster = GameObject.Find("monster");

        MonsterInfo.instance = this;
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
