using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterScript : MonoBehaviour
{
    GameObject player;
    GameObject monster;
    GameObject potion;
    GameObject weapon;
   
    public static MonsterScript instance;

    public GameObject sosi;

    public Vector2 mpos;
    

    void Awake()
    {
        

        
    }

    //  public int monsterhp = 2;

    void Start()
    {
        this.player = GameObject.Find("player");
        this.monster = GameObject.Find("monster");
        this.potion = GameObject.Find("potion");
        this.weapon = GameObject.Find("weapon");

        MonsterScript.instance = this;
        
    }


    public int info1()
    {
        return 1;
    }

    public int info2()
    {
        return 2;
    }




    // Update is called once per frame
    void Update()
    {
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 0.5f;
            


        if (d < r1 + r2) 
        {
            Destroy(gameObject);

                GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                monsterGenerator.GetComponent<MonsterGenerator>().Generate();
         
            
            if(this.gameObject.tag == "Monster1")
            {
                GameObject hpdirector = GameObject.Find("HpDirector");
                hpdirector.GetComponent<HpDirector>().DecreaseHp();

                GameObject scoredirector = GameObject.Find("ScoreRecord");
                scoredirector.GetComponent<ScoreRecord>().record();
            }

            if (this.gameObject.tag == "Monster2")
            {
                GameObject hpdirector2 = GameObject.Find("HpDirector");
                hpdirector2.GetComponent<HpDirector>().DecreaseHp2();

                GameObject scoredirector2 = GameObject.Find("ScoreRecord");
                scoredirector2.GetComponent<ScoreRecord>().record2();

            }

            if (this.gameObject.tag == "Monster3")
            {
                GameObject hpdirector2 = GameObject.Find("HpDirector");
                hpdirector2.GetComponent<HpDirector>().DecreaseHp3();

                GameObject scoredirector2 = GameObject.Find("ScoreRecord");
                scoredirector2.GetComponent<ScoreRecord>().record3();

            }

            if (this.gameObject.tag == "Monster4")
            {
                GameObject hpdirector2 = GameObject.Find("HpDirector");
                hpdirector2.GetComponent<HpDirector>().DecreaseHp4();

                GameObject scoredirector2 = GameObject.Find("ScoreRecord");
                scoredirector2.GetComponent<ScoreRecord>().record4();

            }


            if (this.gameObject.tag == "potion")
            {
                GameObject hpdirector3 = GameObject.Find("HpDirector");
                hpdirector3.GetComponent<HpDirector>().UpHp();
            }

            if (this.gameObject.tag == "potion2")
            {
                GameObject hpdirector3 = GameObject.Find("HpDirector");
                hpdirector3.GetComponent<HpDirector>().DownHp();
            }



            if (this.gameObject.tag == "weapon")
            {
                GameObject hpdirector4 = GameObject.Find("HpDirector");
                hpdirector4.GetComponent<HpDirector>().Duration();
            }

            if (this.gameObject.tag == "coin")
            {
                GameObject scoredirector3 = GameObject.Find("ScoreRecord");
                scoredirector3.GetComponent<ScoreRecord>().record3();
            }


        }
        /*
        if (SkillDirector2.instance.Fire() == 0 && d < r3 + r4)
        {


            Destroy(gameObject);


            if (this.gameObject.tag == "Monster1")
            {
                GameObject scoredirector = GameObject.Find("ScoreRecord");
                scoredirector.GetComponent<ScoreRecord>().record();
            }

            if (this.gameObject.tag == "Monster2")
            {
                GameObject scoredirector2 = GameObject.Find("ScoreRecord");
                scoredirector2.GetComponent<ScoreRecord>().record2();

            }
            */
              /*
            float px1 = Random.Range(-4.7f, -1.2f);
            float px2 = Random.Range(-1.2f, 2.3f);
            float px3 = Random.Range(2.3f, 5.8f);

            float py1 = Random.Range(4.9f, 1.4f);
            float py2 = Random.Range(1.4f, -2.1f);
            float py3 = Random.Range(-2.1f, 5.6f);

           // GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
            //monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate1();
            //monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate2();
            //monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate3();
            //monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate4();
            //monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate5();
            //monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate6();
            //monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate7();
            //monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate8();
            //monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate9();

            //if(d<r1+r2)
            //{
             //   Destroy(gameObject);
           // }

            
             
            if (sMove.nowchar == new Vector2(px1, py1))
            { 
            GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
            monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate2();
            monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate3();
            monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate4();
            monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate5();
            monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate6();
            monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate7();
            monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate8();
            monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate9();
            }

           // float px2 = Random.Range(-1.2f, 2.3f);
            //float py2 = Random.Range(4.9f, 1.4f);

            if (sMove.nowchar == new Vector2(px2, py1))
            {
                GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate1();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate3();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate4();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate5();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate6();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate7();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate8();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate9();
            }

            //float px3 = Random.Range(2.3f, 5.8f);
            //float py3 = Random.Range(4.9f, 1.4f);

            if (sMove.nowchar == new Vector2(px3, py1))
            {
                GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate2();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate1();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate4();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate5();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate6();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate7();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate8();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate9();
            }

            //float px4 = Random.Range(-4.7f, -1.2f);
           // float py4 = Random.Range(1.4f, -2.1f);

            if (sMove.nowchar == new Vector2(px2, py1))
            {
                GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate2();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate3();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate1();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate5();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate6();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate7();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate8();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate9();
            }

            //float px5 = Random.Range(-1.2f, 2.3f);
            //float py5 = Random.Range(1.4f, -2.1f);

            if (sMove.nowchar == new Vector2(px2, py2))
            {
                GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate2();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate3();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate4();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate1();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate6();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate7();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate8();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate9();
            }

            //float px6 = Random.Range(2.3f, 5.8f);
            //float py6 = Random.Range(1.4f, -2.1f); ;

            if (sMove.nowchar == new Vector2(px2, py3))
            {
                GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate2();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate3();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate4();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate5();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate1();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate7();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate8();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate9();
            }

            //float px7 = Random.Range(-4.7f, -1.2f);
            //float py7 = Random.Range(-2.1f, -5.6f);

            if (sMove.nowchar == new Vector2(px3, py1))
            {
                GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate2();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate3();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate4();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate5();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate6();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate1();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate8();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate9();
            }

           // float px8 = Random.Range(-1.2f, 2.3f);
            //float py8 = Random.Range(-2.1f, -5.6f);

            if (sMove.nowchar == new Vector2(px3, py2))
            {
                GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate2();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate3();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate4();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate5();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate6();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate7();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate1();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate9();
            }

            //float px9 = Random.Range(2.3f, 5.8f);
            //float py9 = Random.Range(-2.1f, -5.6f);

            if (sMove.nowchar == new Vector2(px3, py3))
            {
                GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate2();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate3();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate4();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate5();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate6();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate7();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate8();
                monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate1();
            }

                
    */
        }

    
   
    


}

    