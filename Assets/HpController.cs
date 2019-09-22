using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpController : MonoBehaviour
{
    public GameObject playerhp;
    public GameObject weaponhp;


    void Start()
    {
        this.playerhp = GameObject.Find("playerhp");
        this.weaponhp = GameObject.Find("weaponhp");
    }



    public void LButtonDown()
    {
        transform.Translate(-100.0f, 0, 0);
        //transform.Translate(-330.0f, 0, 0); //갤럭시6용
        //Debug.Log(transform.position.y);
    }

    public void RButtonDown()
    {
        transform.Translate(100.0f, 0, 0);
        //transform.Translate(330.0f, 0, 0); //갤럭시6용
    }

    public void UButtonDown()
    {
        transform.Translate(0, 135.0f, 0);
        //transform.Translate(0,400.0f, 0); //갤럭시6용

    }

    public void DButtonDown()
    {
        transform.Translate(0, -135.0f, 0);
        //transform.Translate(0, -400.0f, 0); //갤럭시6용

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
