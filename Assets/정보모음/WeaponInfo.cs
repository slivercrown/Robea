using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInfo : MonoBehaviour
{
    GameObject weapon;

    public static WeaponInfo instance;

    public int duration = 4;

    void Start()
    {
        this.weapon = GameObject.Find("weapon");

        WeaponInfo.instance = this;
    }

    public int Dur()
    {
        return duration;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
