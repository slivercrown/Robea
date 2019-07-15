using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionInfo2 : MonoBehaviour
{
    GameObject potion2;

    public static PotionInfo2 instance;

    public int hpdown = -2;

    void Start()
    {
        this.potion2 = GameObject.Find("potion2");

        PotionInfo2.instance = this;
    }

    public int Down()
    {
        return hpdown;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
