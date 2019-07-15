
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterGenerator : MonoBehaviour
{
    GameObject player;

    public GameObject monsterPrefab;

    public GameObject monsterPrefab2;

    public GameObject potionPrefab;

    public GameObject potionPrefab2;

    public GameObject weaponPrefab;

    public GameObject monsterPrefab3;

    public GameObject monsterPrefab4;

    public GameObject coinPrefab;

    public GameObject posi;

    CharacterMove cMove;


    void Start()
    {
        this.player = GameObject.Find("player");



        cMove = player.GetComponent<CharacterMove>();

    }




    // 충돌했다는걸 전달 받고 플레이어가 있던 위치에 몬스터를 소환한다.


    public void Generate()
    {

        int num;
        num = Random.Range(1, 9);

        if (num == 1 || num == 5)
        {
            GameObject go = Instantiate(monsterPrefab) as GameObject;
            go.transform.position = cMove.beforechar;
        }

        if (num == 2 || num == 6)
        {
            GameObject go2 = Instantiate(monsterPrefab2) as GameObject;
            go2.transform.position = cMove.beforechar;
        }

        if (num == 3)
        {
            GameObject go3 = Instantiate(potionPrefab) as GameObject;
            go3.transform.position = cMove.beforechar;
        }

        if (num == 4)
        {
            GameObject go4 = Instantiate(weaponPrefab) as GameObject;
            go4.transform.position = cMove.beforechar;
        }

        if (num == 7)
        {
            GameObject go5 = Instantiate(potionPrefab2) as GameObject;
            go5.transform.position = cMove.beforechar;
        }

        if (num == 8)
        {
            GameObject go5 = Instantiate(coinPrefab) as GameObject;
            go5.transform.position = cMove.beforechar;
        }


    }
    
    public void GenerateF()
    {
        int num;
        num = Random.Range(1, 8);

        if (num == 1 || num == 5)
        {
            GameObject go = Instantiate(monsterPrefab) as GameObject;
            go.transform.position = cMove.beforechar;
        }

        if (num == 2 || num == 6)
        {
            GameObject go2 = Instantiate(monsterPrefab2) as GameObject;
            go2.transform.position = cMove.beforechar;
        }

        if (num == 3)
        {
            GameObject go3 = Instantiate(potionPrefab) as GameObject;
            go3.transform.position = cMove.beforechar;
        }

        if (num == 4)
        {
            GameObject go4 = Instantiate(weaponPrefab) as GameObject;
            go4.transform.position = cMove.beforechar;
        }

        if (num == 7)
        {
            GameObject go5 = Instantiate(potionPrefab2) as GameObject;
            go5.transform.position = cMove.beforechar;
        }
    }

    public void FireGenerate1()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(-1.9f, 3.75f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(-1.9f, 3.75f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(-1.9f, 3.75f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(-1.9f, 3.75f, 0);
        }

        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(-1.9f, 3.75f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(-1.9f, 3.75f, 0);
        }

    }
    public void FireGenerate2()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(0, 3.75f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(0, 3.75f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(0, 3.75f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(0, 3.75f, 0);
        }

        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(0, 3.75f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(0, 3.75f, 0);
        }

    }

    public void FireGenerate3()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(1.9f, 3.75f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(1.9f, 3.75f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(1.9f, 3.75f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(1.9f, 3.75f, 0);
        }
        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(1.9f, 3.75f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(1.9f, 3.75f, 0);
        }

    }

    public void FireGenerate4()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(-1.9f, 1.2f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(-1.9f, 1.2f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(-1.9f, 1.2f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(-1.9f, 1.2f, 0);
        }
        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(-1.9f, 1.2f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(-1.9f, 1.2f, 0);
        }

    }

    public void FireGenerate6()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(1.9f, 1.2f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(1.9f, 1.2f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(1.9f, 1.2f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(1.9f, 1.2f, 0);
        }
        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(1.9f, 1.2f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(1.9f, 1.2f, 0);
        }

    }

    public void FireGenerate7()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(-1.9f, -1.35f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(-1.9f, -1.35f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(-1.9f, -1.35f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(-1.9f, -1.35f, 0);
        }
        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(-1.9f, -1.35f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(-1.9f, -1.35f, 0);
        }

    }

    public void FireGenerate8()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(0.0f, -1.35f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(0.0f, -1.35f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(0.0f, -1.35f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(0.0f, -1.35f, 0);
        }
        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(0.0f, -1.35f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(0.0f, -1.35f, 0);
        }

    }

    public void FireGenerate9()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(1.9f, -1.35f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(1.9f, -1.35f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(1.9f, -1.35f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(1.9f, -1.35f, 0);
        }
        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(1.9f, -1.35f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(1.9f, -1.35f, 0);
        }

    }

    public void FireGenerate5()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(0, 1.2f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(0, 1.2f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(0, 1.2f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(0, 1.2f, 0);
        }
        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(0, 1.2f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(0, 1.2f, 0);
        }

    }


    public void StartGenerate1()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(-1.9f, 3.75f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(-1.9f, 3.75f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(-1.9f, 3.75f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(-1.9f, 3.75f, 0);
        }

        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(-1.9f, 3.75f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(-1.9f, 3.75f, 0);
        }

    }
    public void StartGenerate2()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(0, 3.75f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(0, 3.75f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(0, 3.75f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(0, 3.75f, 0);
        }

        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(0, 3.75f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(0, 3.75f, 0);
        }

    }

    public void StartGenerate3()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(1.9f, 3.75f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(1.9f, 3.75f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(1.9f, 3.75f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(1.9f, 3.75f, 0);
        }
        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(1.9f, 3.75f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(1.9f, 3.75f, 0);
        }

    }

    public void StartGenerate4()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(-1.9f, 1.2f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(-1.9f, 1.2f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(-1.9f, 1.2f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(-1.9f, 1.2f, 0);
        }
        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(-1.9f, 1.2f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(-1.9f, 1.2f, 0);
        }

    }

    public void StartGenerate5()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(1.9f, 1.2f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(1.9f, 1.2f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(1.9f, 1.2f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(1.9f, 1.2f, 0);
        }
        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(1.9f, 1.2f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(1.9f, 1.2f, 0);
        }

    }

    public void StartGenerate6()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(-1.9f, -1.35f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(-1.9f, -1.35f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(-1.9f, -1.35f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(-1.9f, -1.35f, 0);
        }
        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(-1.9f, -1.35f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(-1.9f, -1.35f, 0);
        }

    }

    public void StartGenerate7()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(0.0f, -1.35f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(0.0f, -1.35f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(0.0f, -1.35f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(0.0f, -1.35f, 0);
        }
        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(0.0f, -1.35f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(0.0f, -1.35f, 0);
        }

    }

    public void StartGenerate8()
    {
        int num2;
        num2 = Random.Range(1, 6);

        if (num2 == 1)
        {
            GameObject so = Instantiate(monsterPrefab) as GameObject;
            so.transform.position = new Vector3(1.9f, -1.35f, 0);
        }

        else if (num2 == 2)
        {
            GameObject so2 = Instantiate(monsterPrefab2) as GameObject;
            so2.transform.position = new Vector3(1.9f, -1.35f, 0);
        }

        else if (num2 == 3)
        {
            GameObject so3 = Instantiate(potionPrefab) as GameObject;
            so3.transform.position = new Vector3(1.9f, -1.35f, 0);
        }

        else if (num2 == 4)
        {
            GameObject so4 = Instantiate(weaponPrefab) as GameObject;
            so4.transform.position = new Vector3(1.9f, -1.35f, 0);
        }
        else if (num2 == 5)
        {
            GameObject so5 = Instantiate(potionPrefab2) as GameObject;
            so5.transform.position = new Vector3(1.9f, -1.35f, 0);
        }

        else
        {
            GameObject so6 = Instantiate(coinPrefab) as GameObject;
            so6.transform.position = new Vector3(1.9f, -1.35f, 0);
        }

    }

}





