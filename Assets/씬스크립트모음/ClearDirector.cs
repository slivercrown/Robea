using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Start!");
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        Screen.SetResolution(900, 1600, false);
       
    }

    
    public void SButtonDown()
    {
        SceneManager.LoadScene("GameScene2");
    }

    public void EButtonDown()
    {

        Application.Quit();

    }



}
