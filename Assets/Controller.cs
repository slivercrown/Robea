using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public static Controller instance;

    public bool sd2;


    public bool se;

    void Start()
    {
        Controller.instance = this;
        sd2 = false;
    }

    public bool SD()
    {
        return sd2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
