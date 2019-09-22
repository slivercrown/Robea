using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SkillSceneDirector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void RButtonDown()
    {
        SceneManager.LoadScene("StartScene2");
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
