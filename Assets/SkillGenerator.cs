using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillGenerator : MonoBehaviour
{
    public static SkillGenerator instance;



    public int a = 3;
    public int k = 0;

    public int r1 = 1;
    public int r2 = 1;
    public int r3 = 1;
    public int r4 = 1;

    public int sum = 0;


    public GameObject skillPrefab;

    public GameObject skillPrefab2;

    public GameObject skillPrefab3;

    public GameObject skillPrefab4;



    void Start()
    {
        
        SkillGenerator.instance = this;

    }

    public void Select1Down()
    {
        if (a == 0)
            GetComponent<Button>().interactable = false;

        if(r1==0)
            GetComponent<Button>().interactable = false;

        if (k == 0)

        {
            GameObject go = Instantiate(skillPrefab) as GameObject;
            go.transform.position = new Vector3(-1.5f, -3, 0);
        }

        if (k == 1)

        {
            GameObject go = Instantiate(skillPrefab) as GameObject;
            go.transform.position = new Vector3(0.0f, -3, 0);
        }

        if (k == 2)

        {
            GameObject go = Instantiate(skillPrefab) as GameObject;
            go.transform.position = new Vector3(1.5f, -3, 0);
        }

        a -= 1;
        k += 1;
        r1 = 0;
        sum += 1;
    }

    public void Select2Down()
    {
        if (a == 0)
            GetComponent<Button>().interactable = false;
        if (r2 == 0)
            GetComponent<Button>().interactable = false;

        if (k == 0)

        {
            GameObject go = Instantiate(skillPrefab2) as GameObject;
            go.transform.position = new Vector3(-1.5f, -3, 0);
        }

        if (k == 1)

        {
            GameObject go = Instantiate(skillPrefab2) as GameObject;
            go.transform.position = new Vector3(0.0f, -3, 0);
        }

        if (k == 2)

        {
            GameObject go = Instantiate(skillPrefab2) as GameObject;
            go.transform.position = new Vector3(1.5f, -3, 0);
        }

        a -= 1;
        k += 1;
        r2 = 0;
        sum += 2;

    }

    public void Select3Down()
    {
        if (a == 0)
            GetComponent<Button>().interactable = false;
        if (r3 == 0)
            GetComponent<Button>().interactable = false;

        if (k == 0)

        {
            GameObject go = Instantiate(skillPrefab3) as GameObject;
            go.transform.position = new Vector3(-1.5f, -3, 0);
        }

        if (k == 1)

        {
            GameObject go = Instantiate(skillPrefab3) as GameObject;
            go.transform.position = new Vector3(0.0f, -3, 0);
        }

        if (k == 2)

        {
            GameObject go = Instantiate(skillPrefab3) as GameObject;
            go.transform.position = new Vector3(1.5f, -3, 0);
        }

        a -= 1;
        k += 1;
        r3 = 0;
        sum += 3;

    }

    public void Select4Down()
    {
        if (a == 0)
            GetComponent<Button>().interactable = false;
        if (r4 == 0)
            GetComponent<Button>().interactable = false;

        if (k == 0)

        {
            GameObject go = Instantiate(skillPrefab4) as GameObject;
            go.transform.position = new Vector3(-1.5f, -3, 0);
        }

        if (k == 1)

        {
            GameObject go = Instantiate(skillPrefab4) as GameObject;
            go.transform.position = new Vector3(0.0f, -3, 0);
        }

        if (k == 2)

        {
            GameObject go = Instantiate(skillPrefab4) as GameObject;
            go.transform.position = new Vector3(1.5f, -3, 0);
        }

        a -= 1;
        k += 1;
        r4 = 0;
        sum += 4;
    }

    public void restart()
    {
        
      
        a = 3;
        k = 0;
        r1 = 1;
        r2 = 1;
        r3 = 1;
        r4 = 1;
        sum = 0;


    }


    public int TossSum()
        
    {
        return sum;
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
