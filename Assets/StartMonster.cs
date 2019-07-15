using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMonster : MonoBehaviour
{
    public GameObject monsterstart;

    public static StartMonster instance;

    void Start()
    {
        StartMonster.instance = this;

        this.monsterstart = GameObject.Find("monsterstart");

        GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
        monsterGenerator.GetComponent<MonsterGenerator>().StartGenerate1();
        monsterGenerator.GetComponent<MonsterGenerator>().StartGenerate2();
        monsterGenerator.GetComponent<MonsterGenerator>().StartGenerate3();
        monsterGenerator.GetComponent<MonsterGenerator>().StartGenerate4();
        monsterGenerator.GetComponent<MonsterGenerator>().StartGenerate5();
        monsterGenerator.GetComponent<MonsterGenerator>().StartGenerate6();
        monsterGenerator.GetComponent<MonsterGenerator>().StartGenerate7();
        monsterGenerator.GetComponent<MonsterGenerator>().StartGenerate8();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
