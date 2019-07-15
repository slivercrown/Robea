using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillEffect : MonoBehaviour
{

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

        SkillEffect.instance = this;



    }





    void Update()
    {
        if (StartScene.instance.SD())
        {
            if (SkillDirector2.instance.count == 0)

            {
                
                
                Debug.Log("///////////////////////////////////////////" + SkillDirector2.instance.count);
                

                if (gameObject.transform.position.x > -3.0f && gameObject.transform.position.x < -1.0f && gameObject.transform.position.y > 3.0f && gameObject.transform.position.y < 4.0f)

                {
                    Destroy(gameObject);
                    Debug.Log("1번입니다.");
                    GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                    monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate1();
                    

                }
                if (gameObject.transform.position.x > -1.0f && gameObject.transform.position.x < 1.0f && gameObject.transform.position.y > 3.0f && gameObject.transform.position.y < 4.0f)
                {

                    //Destroy(gameObject);
                    Debug.Log("2번입니다.");
                    GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                    monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate2();


                }

                if (gameObject.transform.position.x > 1.0f && gameObject.transform.position.x < 3.0f && gameObject.transform.position.y > 3.0f && gameObject.transform.position.y < 4.0f)
                {

                    //Destroy(gameObject);
                    Debug.Log("3번입니다.");
                    GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                    monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate3();


                }

                if (gameObject.transform.position.x > -3.0f && gameObject.transform.position.x < -1.0f && gameObject.transform.position.y > 1.0f && gameObject.transform.position.y < 2.0f)
                {

                    //Destroy(gameObject);
                    Debug.Log("4번입니다.");
                    GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                    monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate4();


                }

                if (gameObject.transform.position.x > -1.0f && gameObject.transform.position.x < 1.0f && gameObject.transform.position.y > 1.0f && gameObject.transform.position.y < 2.0f)
                {

                    // Destroy(gameObject);
                    Debug.Log("5번입니다.");
                    GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                    monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate5();


                }

                if (gameObject.transform.position.x > 1.0f && gameObject.transform.position.x < 3.0f && gameObject.transform.position.y > 1.0f && gameObject.transform.position.y < 2.0f)
                {

                    //Destroy(gameObject);
                    Debug.Log("6번입니다.");
                    GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                    monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate6();


                }

                if (gameObject.transform.position.x > -3.0f && gameObject.transform.position.x < -1.0f && gameObject.transform.position.y > -2.0f && gameObject.transform.position.y < 0.0f)
                {

                    //Destroy(gameObject);
                    Debug.Log("7번입니다.");
                    GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                    monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate7();


                }

                if (gameObject.transform.position.x > -1.0f && gameObject.transform.position.x < 1.0f && gameObject.transform.position.y > -2.0f && gameObject.transform.position.y < 0.0f)
                {

                    //Destroy(gameObject);
                    Debug.Log("8번입니다.");
                    GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                    monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate8();


                }

                if (gameObject.transform.position.x > 1.0f && gameObject.transform.position.x < 3.0f && gameObject.transform.position.y > -2.0f && gameObject.transform.position.y < 0.0f)
                {

                    //Destroy(gameObject);
                    Debug.Log("9번입니다.");
                    GameObject monsterGenerator = GameObject.Find("MonsterGenerator");
                    monsterGenerator.GetComponent<MonsterGenerator>().FireGenerate9();


                }
                SkillDirector2.instance.count = 15;

                this.skill2.GetComponent<Text>().text = "화염폭풍 : " + SkillDirector2.instance.count.ToString("F0");


            }
        }

    }

}   
 



