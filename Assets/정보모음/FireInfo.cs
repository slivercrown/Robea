using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInfo : MonoBehaviour
{
    float delta = 0;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta >= 0.3f)
        Destroy(gameObject);
    }

}