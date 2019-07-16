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


    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1)

            SceneManager.LoadScene("GameScene2");

    
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
