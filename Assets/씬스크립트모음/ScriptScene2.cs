using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptScene2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NButtonDown()
    {
        SceneManager.LoadScene("ScriptScene3");
    }

    public void BButtonDown()
    {
        SceneManager.LoadScene("ScriptScene1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
