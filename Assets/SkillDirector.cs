using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillDirector : MonoBehaviour
{
    GameObject skill;

    
    public float t;

    public int count1;

   
   

    public static SkillDirector instance;

    void Start()
    {
       
        this.skill = GameObject.Find("skill");
        
        SkillDirector.instance = this;

        count1 = 12;
        this.skill.GetComponent<Text>().text = "TimeWind : " + this.count1.ToString("F0");
        //this.skill.GetComponent<Text>().text = "시간되돌리기 : " + SkillDirector.instance.Wind().ToString("F0");

        
    }
    
        public void LButtonDown()
        {
            count1 -= 1;
            this.skill.GetComponent<Text>().text = "TimeWind : " + this.count1.ToString("F0");
          //  Debug.Log(count1);
        }

        public void RButtonDown()
        {
            count1 -= 1;
            this.skill.GetComponent<Text>().text = "TimeWind : " + this.count1.ToString("F0");
        //Debug.Log(count1);
        }

        public void UButtonDown()
        {
            count1 -= 1;
            this.skill.GetComponent<Text>().text = "TimeWind : " + this.count1.ToString("F0");
       //    Debug.Log(count1);
        }

        public void DButtonDown()
        {
            count1 -= 1;
            this.skill.GetComponent<Text>().text = "TimeWind : " + this.count1.ToString("F0");
        //    Debug.Log(count1);
        }

    
        
    public float TimeWind()
    {

        t = TimeLimit.instance.limittime;

        
        if (count1 <= 0)
        { 
        t = TimeLimit.instance.limittime;

        t += 2;
        TimeLimit.instance.limittime += 2;

        count1 = 12;
        this.skill.GetComponent<Text>().text = "TimeWind : " + this.count1.ToString("F0");

        }

        return t;
        


    }
    
  


    void Update()
    {
        

    }
}
