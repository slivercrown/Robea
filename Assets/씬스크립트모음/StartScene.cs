using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public static StartScene instance;

    public bool flag =false;

    void Start()
    {
        Screen.SetResolution(900, 1600 , true);
        
        
        
        instance = this;
   
    }

    public bool SD()
    {
        return flag;
    }

   public void SDON()
    {
        flag = true;
    }

    public void SButtonDown()
    {
        SceneManager.LoadScene("GameScene2");
    }

    public void EButtonDown()
    {
        SceneManager.LoadScene("ScriptScene");
    }

    public void RButtonDown()
    {
        SceneManager.LoadScene("RankingScene");
    }

    public void KButtonDown()
    {
        SceneManager.LoadScene("SkillScene");
    }


    // Update is called once per frame
    void Update()
    {
      
    }
}
