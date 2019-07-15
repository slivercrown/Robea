using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinInfo : MonoBehaviour
{
    GameObject coin;

    public static CoinInfo instance;

    public int scoreup = 3;

    void Start()
    {
        this.coin = GameObject.Find("coin");

        CoinInfo.instance = this;
    }

    public int ScoreUp()
    {
        return scoreup;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
