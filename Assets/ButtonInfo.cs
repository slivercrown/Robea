using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    GameObject skillicon1;
    GameObject skillicon2;
    GameObject skillicon3;
    GameObject skillicon4;

    void Start()
    {

        this.skillicon1 = GameObject.Find("skillicon1");
        this.skillicon2 = GameObject.Find("skillicon2");
        this.skillicon3 = GameObject.Find("skillicon3");
        this.skillicon4 = GameObject.Find("skillicon4");

    }

    public void Remove()
    {
        

            Destroy(gameObject);
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
