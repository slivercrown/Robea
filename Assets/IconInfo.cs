using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconInfo : MonoBehaviour
{
    public GameObject skillPrefab;

    public GameObject skillPrefab2;

    public GameObject skillPrefab3;

    public GameObject skillPrefab4;


    void Start()
    {

        if(SkillGenerator.instance.TossSum() == 6)

        {
            GameObject go = Instantiate(skillPrefab) as GameObject;
            go.transform.position = new Vector3(-2.0f, -4, 0);

            GameObject go2 = Instantiate(skillPrefab2) as GameObject;
            go2.transform.position = new Vector3(0.0f, -4, 0);

            GameObject go3 = Instantiate(skillPrefab3) as GameObject;
            go3.transform.position = new Vector3(2.0f, -4, 0);

        }

        if (SkillGenerator.instance.TossSum() == 7)

        {
            GameObject go = Instantiate(skillPrefab) as GameObject;
            go.transform.position = new Vector3(-2.0f, -4, 0);

            GameObject go2 = Instantiate(skillPrefab2) as GameObject;
            go2.transform.position = new Vector3(0.0f, -4, 0);

            GameObject go4 = Instantiate(skillPrefab4) as GameObject;
            go4.transform.position = new Vector3(2.0f, -4, 0);

        }

        if (SkillGenerator.instance.TossSum() == 8)

        {
            GameObject go = Instantiate(skillPrefab) as GameObject;
            go.transform.position = new Vector3(-2.0f, -4, 0);

            GameObject go3 = Instantiate(skillPrefab3) as GameObject;
            go3.transform.position = new Vector3(0.0f, -4, 0);

            GameObject go4 = Instantiate(skillPrefab4) as GameObject;
            go4.transform.position = new Vector3(-2.0f, -4, 0);
        }

        if (SkillGenerator.instance.TossSum() == 9)

        {
            GameObject go2 = Instantiate(skillPrefab2) as GameObject;
            go2.transform.position = new Vector3(-2.0f, -4, 0);

            GameObject go3 = Instantiate(skillPrefab3) as GameObject;
            go3.transform.position = new Vector3(0.0f, -4, 0);

            GameObject go4 = Instantiate(skillPrefab4) as GameObject;
            go4.transform.position = new Vector3(-2.0f, -4, 0);


        }




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
