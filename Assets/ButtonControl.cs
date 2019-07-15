using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{

   GameObject LButton;
    GameObject RButton;
    GameObject UButton;
    GameObject DButton;

    public float maxx = 300.0f;
    public float minx = -300.0f;
    public float maxy = 3.6f;
    public float miny = -1.2f;

    void Start()
    {
       this.LButton = GameObject.Find("LBUtton");
       this.RButton = GameObject.Find("RBUtton");
       this.DButton = GameObject.Find("DBUtton");
       this.UButton = GameObject.Find("UBUtton");


    }


    public void LButtonDown()
    {
        transform.Translate(-80.0f, 0, 0);  
        //transform.Translate(-300.0f, 0, 0); //갤럭시6용
        Debug.Log(transform.position.y);
    }

    public void RButtonDown()
    {
        transform.Translate(80.0f, 0, 0);
        //transform.Translate(300.0f, 0, 0); //갤럭시6용
    }

    public void UButtonDown()
    {
        transform.Translate(0, 180.0f, 0);
        //transform.Translate(0,360.0f, 0); //갤럭시6용

    }

    public void DButtonDown()
    {
        transform.Translate(0, -180.0f, 0);
        //transform.Translate(0, -360.0f, 0); //갤럭시6용

    }


    // Update is called once per frame
    /// <summary>
    /*
    </summary>
       void Update()
       {

           {
               if (CharacterMove.instance.Minput() == 1)
               {
                   transform.Translate(-100.0f, 0, 0);
                   a = 0;
                   Debug.Log(transform.position.x);
               }

               if (CharacterMove.instance.Minput() == 2)
               { 
                   transform.Translate(100.0f, 0, 0);
                    a = 0;
                   Debug.Log(transform.position.x);
               }

           if (CharacterMove.instance.Minput() == 3)
               { 
                   transform.Translate(0, -100.0f, 0);
                   a = 0;
                   Debug.Log(transform.position.x);
               }

               if (CharacterMove.instance.Minput() == 4)
               { 
                   transform.Translate(0, 100.0f, 0);
                   a = 0;
                   Debug.Log(transform.position.x);
               }
           }
       }
       */
}
