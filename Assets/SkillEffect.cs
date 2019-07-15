using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillEffect : MonoBehaviour
{

    GameObject player;
    GameObject monster;
    GameObject potion;
    GameObject weapon;
    GameObject skill2;

    public static SkillEffect instance;



    void Start()
    {

        this.monster = GameObject.Find("monster");
        this.potion = GameObject.Find("potion");
        this.weapon = GameObject.Find("weapon");
        this.skill2 = GameObject.Find("skill2");
        this.player = GameObject.Find("player");

        SkillEffect.instance = this;



    }



  void Update()
    {
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r3 = 8.0f;
        float r4 = 8.0f;


        if (StartScene.instance.SD()==true)
        {
            if (SkillDirector2.instance.count <= 0)

            {
                if (d < r3 + r4)
                {
                   
                        Destroy(gameObject);

                        Debug.Log("///////////////////////////////////////////" + SkillDirector2.instance.count);


                        if (gameObject.transform.position.x > -3.0f && gameObject.transform.position.x < -1.0f && gameObject.transform.position.y > 3.0f && gameObject.transform.position.y < 4.0f)

                        {

                            Debug.Log("1번입니다.");
                            GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                            monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate1();

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

                        if (this.gameObject.tag == "Monster3")

                        {
                             GameObject scoredirector = GameObject.Find("ScoreRecord");
                             scoredirector.GetComponent<ScoreRecord>().record5();
                        }

                        if (this.gameObject.tag == "Monster4")
                        {
                              GameObject scoredirector4 = GameObject.Find("ScoreRecord");
                              scoredirector4.GetComponent<ScoreRecord>().record4();
                        }

                        
                        if (this.gameObject.tag == "coin")
                        {
                              GameObject scoredirector3 = GameObject.Find("ScoreRecord");
                              scoredirector3.GetComponent<ScoreRecord>().record3();
                        }


                        }


                        if (gameObject.transform.position.x > -1.0f && gameObject.transform.position.x < 1.0f && gameObject.transform.position.y > 3.0f && gameObject.transform.position.y < 4.0f)
                        {


                            Debug.Log("2번입니다.");
                            GameObject monsterGenerator2 = GameObject.Find("MonsterGenerator");
                            monsterGenerator2.GetComponent<MonsterGenerator>().FireGenerate2();


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

                        if (this.gameObject.tag == "Monster3")

                        {
                            GameObject scoredirector = GameObject.Find("ScoreRecord");
                            scoredirector.GetComponent<ScoreRecord>().record5();
                        }

                        if (this.gameObject.tag == "Monster4")
                        {
                            GameObject scoredirector4 = GameObject.Find("ScoreRecord");
                            scoredirector4.GetComponent<ScoreRecord>().record4();
                        }

                        
                        if (this.gameObject.tag == "coin")
                        {
                            GameObject scoredirector3 = GameObject.Find("ScoreRecord");
                            scoredirector3.GetComponent<ScoreRecord>().record3();
                        }


                        }

                        if (gameObject.transform.position.x > 1.0f && gameObject.transform.position.x < 3.0f && gameObject.transform.position.y > 3.0f && gameObject.transform.position.y < 4.0f)
                        {

                            //Destroy(gameObject);
                            Debug.Log("3번입니다.");
                            GameObject monsterGenerator3 = GameObject.Find("MonsterGenerator");
                            monsterGenerator3.GetComponent<MonsterGenerator>().FireGenerate3();
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

                        if (this.gameObject.tag == "Monster3")

                        {
                            GameObject scoredirector = GameObject.Find("ScoreRecord");
                            scoredirector.GetComponent<ScoreRecord>().record5();
                        }

                        if (this.gameObject.tag == "Monster4")
                        {
                            GameObject scoredirector4 = GameObject.Find("ScoreRecord");
                            scoredirector4.GetComponent<ScoreRecord>().record4();
                        }


                        if (this.gameObject.tag == "coin")
                        {
                            GameObject scoredirector3 = GameObject.Find("ScoreRecord");
                            scoredirector3.GetComponent<ScoreRecord>().record3();
                        }

                    }

                        if (gameObject.transform.position.x > -3.0f && gameObject.transform.position.x < -1.0f && gameObject.transform.position.y > 1.0f && gameObject.transform.position.y < 2.0f)
                        {

                            //Destroy(gameObject);
                            Debug.Log("4번입니다.");
                            GameObject monsterGenerator4 = GameObject.Find("MonsterGenerator");
                            monsterGenerator4.GetComponent<MonsterGenerator>().FireGenerate4();
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

                        if (this.gameObject.tag == "Monster3")

                        {
                            GameObject scoredirector = GameObject.Find("ScoreRecord");
                            scoredirector.GetComponent<ScoreRecord>().record5();
                        }

                        if (this.gameObject.tag == "Monster4")
                        {
                            GameObject scoredirector4 = GameObject.Find("ScoreRecord");
                            scoredirector4.GetComponent<ScoreRecord>().record4();
                        }


                        if (this.gameObject.tag == "coin")
                        {
                            GameObject scoredirector3 = GameObject.Find("ScoreRecord");
                            scoredirector3.GetComponent<ScoreRecord>().record3();
                        }

                    }

                        if (gameObject.transform.position.x > -1.0f && gameObject.transform.position.x < 1.0f && gameObject.transform.position.y > 1.0f && gameObject.transform.position.y < 2.0f)
                        {

                            // Destroy(gameObject);
                            Debug.Log("5번입니다.");
                            GameObject monsterGenerator5 = GameObject.Find("MonsterGenerator");
                            monsterGenerator5.GetComponent<MonsterGenerator>().FireGenerate5();
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

                        if (this.gameObject.tag == "Monster3")

                        {
                            GameObject scoredirector = GameObject.Find("ScoreRecord");
                            scoredirector.GetComponent<ScoreRecord>().record5();
                        }

                        if (this.gameObject.tag == "Monster4")
                        {
                            GameObject scoredirector4 = GameObject.Find("ScoreRecord");
                            scoredirector4.GetComponent<ScoreRecord>().record4();
                        }


                        if (this.gameObject.tag == "coin")
                        {
                            GameObject scoredirector3 = GameObject.Find("ScoreRecord");
                            scoredirector3.GetComponent<ScoreRecord>().record3();
                        }

                    }

                        if (gameObject.transform.position.x > 1.0f && gameObject.transform.position.x < 3.0f && gameObject.transform.position.y > 1.0f && gameObject.transform.position.y < 2.0f)
                        {

                            //Destroy(gameObject);
                            Debug.Log("6번입니다.");
                            GameObject monsterGenerator6 = GameObject.Find("MonsterGenerator");
                            monsterGenerator6.GetComponent<MonsterGenerator>().FireGenerate6();

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

                        if (this.gameObject.tag == "Monster3")

                        {
                            GameObject scoredirector = GameObject.Find("ScoreRecord");
                            scoredirector.GetComponent<ScoreRecord>().record5();
                        }

                        if (this.gameObject.tag == "Monster4")
                        {
                            GameObject scoredirector4 = GameObject.Find("ScoreRecord");
                            scoredirector4.GetComponent<ScoreRecord>().record4();
                        }


                        if (this.gameObject.tag == "coin")
                        {
                            GameObject scoredirector3 = GameObject.Find("ScoreRecord");
                            scoredirector3.GetComponent<ScoreRecord>().record3();
                        }
                    }

                        else if (gameObject.transform.position.x > -3.0f && gameObject.transform.position.x < -1.0f && gameObject.transform.position.y > -2.0f && gameObject.transform.position.y < 0.0f)
                        {

                            //Destroy(gameObject);
                            Debug.Log("7번입니다.");
                            GameObject monsterGenerator7 = GameObject.Find("MonsterGenerator");
                            monsterGenerator7.GetComponent<MonsterGenerator>().FireGenerate7();
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

                        if (this.gameObject.tag == "Monster3")

                        {
                            GameObject scoredirector = GameObject.Find("ScoreRecord");
                            scoredirector.GetComponent<ScoreRecord>().record5();
                        }

                        if (this.gameObject.tag == "Monster4")
                        {
                            GameObject scoredirector4 = GameObject.Find("ScoreRecord");
                            scoredirector4.GetComponent<ScoreRecord>().record4();
                        }


                        if (this.gameObject.tag == "coin")
                        {
                            GameObject scoredirector3 = GameObject.Find("ScoreRecord");
                            scoredirector3.GetComponent<ScoreRecord>().record3();
                        }

                    }

                        if (gameObject.transform.position.x > -1.0f && gameObject.transform.position.x < 1.0f && gameObject.transform.position.y > -2.0f && gameObject.transform.position.y < 0.0f)
                        {

                            //Destroy(gameObject);
                            Debug.Log("8번입니다.");
                            GameObject monsterGenerator8 = GameObject.Find("MonsterGenerator");
                            monsterGenerator8.GetComponent<MonsterGenerator>().FireGenerate8();
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

                        if (this.gameObject.tag == "Monster3")

                        {
                            GameObject scoredirector = GameObject.Find("ScoreRecord");
                            scoredirector.GetComponent<ScoreRecord>().record5();
                        }

                        if (this.gameObject.tag == "Monster4")
                        {
                            GameObject scoredirector4 = GameObject.Find("ScoreRecord");
                            scoredirector4.GetComponent<ScoreRecord>().record4();
                        }


                        if (this.gameObject.tag == "coin")
                        {
                            GameObject scoredirector3 = GameObject.Find("ScoreRecord");
                            scoredirector3.GetComponent<ScoreRecord>().record3();
                        }

                    }

                        if (gameObject.transform.position.x > 1.0f && gameObject.transform.position.x < 3.0f && gameObject.transform.position.y > -2.0f && gameObject.transform.position.y < 0.0f)
                        {

                            //Destroy(gameObject);
                            Debug.Log("9번입니다.");
                            GameObject monsterGenerator9 = GameObject.Find("MonsterGenerator");
                            monsterGenerator9.GetComponent<MonsterGenerator>().FireGenerate9();
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

                        if (this.gameObject.tag == "Monster3")

                        {
                            GameObject scoredirector = GameObject.Find("ScoreRecord");
                            scoredirector.GetComponent<ScoreRecord>().record5();
                        }

                        if (this.gameObject.tag == "Monster4")
                        {
                            GameObject scoredirector4 = GameObject.Find("ScoreRecord");
                            scoredirector4.GetComponent<ScoreRecord>().record4();
                        }


                        if (this.gameObject.tag == "coin")
                        {
                            GameObject scoredirector3 = GameObject.Find("ScoreRecord");
                            scoredirector3.GetComponent<ScoreRecord>().record3();
                        }

                    }

                        SkillDirector2.instance.count = 5;

                        this.skill2.GetComponent<Text>().text = "파이어볼  : " + SkillDirector2.instance.count.ToString("F0");

                    
                }
            }
        }

    }
        
}   
 



