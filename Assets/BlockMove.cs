using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMove : MonoBehaviour
{
    GameObject block;

    // Start is called before the first frame update
    void Start()
    {

        this.block = GameObject.Find("block");
    }


    public void NButtonDown()
    {
        transform.Translate(40.0f, 0, 0);
    }

    public void BButtonDown()
    {
        transform.Translate(-40.0f, 0, 0);
    }



    void Update()
    {

    }
}
