using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptScene1 : MonoBehaviour
{

    GameObject Camera;
    
    // Start is called before the first frame update
    void Start()
    {
        
        this.Camera = GameObject.Find("Camera");
    }
        

    public void NButtonDown()
    {
        transform.Translate(10.0f, 0, 0);
    }

    public void BButtonDown()
    {
        transform.Translate(-10.0f, 0, 0);
    }



    void Update()
    {
        
    }
}
