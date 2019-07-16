using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillDirector2 : MonoBehaviour
{
    GameObject skill2;

    GameObject player;
    GameObject monster;
    

    public int count;

    public int k;

    public static SkillDirector2 instance;


    public GameObject sosi;

    CharacterMove sMove;

    void Start()
    {
        this.skill2 = GameObject.Find("skill2");

        count = 5;
        k = 1;

        instance = this;

        StartScene.instance.SDON();

        
        this.monster = GameObject.Find("monster");
        this.skill2 = GameObject.Find("skill2");



        this.skill2.GetComponent<Text>().text = "Meteor : " + this.count.ToString("F0");
        

    }

    public void LButtonDown()
    {
        count -= 1;
        
        this.skill2.GetComponent<Text>().text = "Meteor  : " + this.count.ToString("F0");

       

    }

    public void RButtonDown()
    {
        count -= 1;
        
        this.skill2.GetComponent<Text>().text = "Meteor  : " + this.count.ToString("F0");

       


    }

    public void UButtonDown()
    {
        count -= 1;

        this.skill2.GetComponent<Text>().text = "Meteor  : " + this.count.ToString("F0");

        


    }

    public void DButtonDown()
    {
        count -= 1;
        
        this.skill2.GetComponent<Text>().text = "Meteor  : " + this.count.ToString("F0");

       
      
    }
    public void FireReset()
    {
        
            count = 5;
            

    }

    

    public int Fire()
    {
        

        return count;


    }

    void Update()
    {

        

        


    }
}
