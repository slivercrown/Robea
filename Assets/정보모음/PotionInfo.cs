using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionInfo : MonoBehaviour
{
    GameObject potion;

    public static PotionInfo instance;

    public int hpup = 3;

    void Start()
    {
        this.potion = GameObject.Find("potion");

        PotionInfo.instance = this;
    }

    public int Up()
    {
        return hpup;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
