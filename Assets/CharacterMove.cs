using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CharacterMove : MonoBehaviour
{

    GameObject player;

     GameObject LButton;
     GameObject RButton;
     GameObject DButton;
     GameObject UButton;


    public static CharacterMove instance;

    public float maxx = 1.8f;
    public float minx = -2.0f;
    public float maxy = 3.6f;
    public float miny = -1.2f;

    public Vector2 nowchar;
    public Vector2 beforechar;

    float key = 0;

    public int input;

    public void IButtonDown()
    {
        SceneManager.LoadScene("InformationScene");
    }





    void Start()
    {

        CharacterMove.instance = this;
        this.player = GameObject.Find("player");
        this.LButton = GameObject.Find("LButton");
        this.RButton = GameObject.Find("RButton");
        this.UButton = GameObject.Find("UButton");
        this.DButton = GameObject.Find("DButton");




    }

    public void LButtonDown()
    {
        transform.Translate(-1.9f, 0, 0);
        key = -0.8f;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
        nowchar = transform.position;
        Debug.Log(nowchar);
        beforechar = nowchar - new Vector2(-1.9f, 0);
        Debug.Log(beforechar);

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 0.8f, 1);
        }
        input = 1;
    }

    public void RButtonDown()
    {
        transform.Translate(1.9f, 0, 0);
        key = 0.8f;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
        nowchar = transform.position;
        Debug.Log(nowchar);
        beforechar = nowchar - new Vector2(1.9f, 0);
        Debug.Log(beforechar);

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 0.8f, 1);
        }
        input = 2;
    }

    public void DButtonDown()
    {
        transform.Translate(0, -2.55f, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy));
        nowchar = transform.position;
        Debug.Log(nowchar);
        beforechar = nowchar - new Vector2(0, -2.55f);
        Debug.Log(beforechar);
        //    Debug.Log(SkillDirector2.instance.Fire());
        // Debug.Log(SkillDirector.instance.Wind());
        input = 3;
    }

    public void UButtonDown()
    {
        transform.Translate(0, 2.55f, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
        nowchar = transform.position;
        Debug.Log(nowchar);
        beforechar = nowchar - new Vector2(0, 2.55f);
        Debug.Log(beforechar);
        // Debug.Log(SkillDirector2.instance.Fire());
        // Debug.Log(SkillDirector.instance.Wind());
        input = 4;
    }

    public int Minput()
    {
        return input;
    }

    void Update()
    {
        float key = 0;
        

        // Debug.Log("플레이어 x좌표" + touchX + "플레이어 y좌표" + touchY);

       



        //캐릭터가 1번위치에 있는경우

        /*
        if ((transform.position.x > -2.3f) && (transform.position.x < -1.0f) && (transform.position.y < 4.0f) && (transform.position.y > 3.0f))
        {
            if (Input.touchCount > 0)
            {
                //아래칸을 누르는 경우 (4번타일)
                if ((myTouch[0].position.x > 0) && (myTouch[0].position.x < 110.0f) && (myTouch[0].position.y > 200.0f) && (myTouch[0].position.y < 280.0f))
                {
                    transform.Translate(0, -2.55f, 0);
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy));
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(0, -2.55f);
                    Debug.Log(beforechar);
                }

                //오른쪽칸을 누르는 경우 (2번타일)
                if ((myTouch[0].position.x > 100.0f) && (myTouch[0].position.x < 150.0f) && (myTouch[0].position.y > 300.0f) && (myTouch[0].position.y < 500.0f))
                {
                    transform.Translate(1.9f, 0, 0);
                    key = 0.8f;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(1.9f, 0);
                    Debug.Log(beforechar);
                }

            }

        }

        //캐릭터가 2번위치에 있는경우

        if ((transform.position.x > -0.2f) && (transform.position.x < 1.0f) && (transform.position.y < 4.0f) && (transform.position.y > 3.0f))
        {
            if (Input.touchCount > 0)
            {
                //왼칸을 누르는 경우 (1번타일)
                if ((myTouch[0].position.x > 0) && (myTouch[0].position.x < 110.0f) && (myTouch[0].position.y > 300.0f) && (myTouch[0].position.y < 500.0f))
                {
                    transform.Translate(-1.9f, 0, 0);
                    key = -0.8f;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(-1.9f, 0);
                    Debug.Log(beforechar);
                }

                //오른쪽칸을 누르는 경우 (3번타일)
                if ((myTouch[0].position.x > 150.0f) && (myTouch[0].position.x < 200.0f) && (myTouch[0].position.y > 300.0f) && (myTouch[0].position.y < 500.0f))
                {
                    transform.Translate(1.9f, 0, 0);
                    key = 0.8f;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(1.9f, 0);
                    Debug.Log(beforechar);
                }

                //아래쪽칸을 누르는 경우 (5번타일)
                if ((myTouch[0].position.x > 100.0f) && (myTouch[0].position.x < 150.0f) && (myTouch[0].position.y > 200.0f) && (myTouch[0].position.y < 300.0f))
                {
                    transform.Translate(0, -2.55f, 0);
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy));
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(0, -2.55f);
                    Debug.Log(beforechar);
                }



            }
        }

        //캐릭터가 3번위치에 있는경우

        if ((transform.position.x > 1.0f) && (transform.position.x < 2.0f) && (transform.position.y < 4.0f) && (transform.position.y > 3.0f))
        {
            if (Input.touchCount > 0)
            {
                //왼칸을 누르는 경우 (2번타일)
                if ((myTouch[0].position.x > 100.0f) && (myTouch[0].position.x < 150.0f) && (myTouch[0].position.y > 300.0f) && (myTouch[0].position.y < 500.0f))
                {
                    transform.Translate(-1.9f, 0, 0);
                    key = -0.8f;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(-1.9f, 0);
                    Debug.Log(beforechar);
                }

                //아래쪽칸을 누르는 경우 (6번타일)
                if ((myTouch[0].position.x > 150.0f) && (myTouch[0].position.x < 300.0f) && (myTouch[0].position.y > 200.0f) && (myTouch[0].position.y < 280.0f))
                {
                    transform.Translate(0, -2.55f, 0);
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy));
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(0, -2.55f);
                    Debug.Log(beforechar);
                }



            }
        }
        //캐릭터가 4번위치에 있는경우

        if ((transform.position.x > -2.2f) && (transform.position.x < -1.0f) && (transform.position.y > 1.0f) && (transform.position.y < 2.0f))
        {
            if (Input.touchCount > 0)
            {
                //위칸을 누르는 경우(1번타일)
                if ((myTouch[0].position.x > 0.0f) && (myTouch[0].position.x < 100.0f) && (myTouch[0].position.y > 300.0f) && (myTouch[0].position.y < 500.0f))
                {
                    transform.Translate(0, 2.55f, 0);
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(0, 2.55f);
                    Debug.Log(beforechar);
                }


                //아래칸을 누르는 경우 (7번타일)
                if ((myTouch[0].position.x > 0) && (myTouch[0].position.x < 110.0f) && (myTouch[0].position.y > 100.0f) && (myTouch[0].position.y < 200.0f))
                {
                    transform.Translate(0, -2.55f, 0);
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy));
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(0, -2.55f);
                    Debug.Log(beforechar);
                }

                //오른쪽칸을 누르는 경우 (5번타일)
                if ((myTouch[0].position.x > 100.0f) && (myTouch[0].position.x < 150.0f) && (myTouch[0].position.y > 200.0f) && (myTouch[0].position.y < 300.0f))
                {
                    transform.Translate(1.9f, 0, 0);
                    key = 0.8f;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(1.9f, 0);
                    Debug.Log(beforechar);
                }

            }


        }
        //캐릭터가 5번위치에 있는경우

        if ((transform.position.x > -0.2f) && (transform.position.x < 1.0f) && (transform.position.y < 2.0f) && (transform.position.y > 1.0f))
        {
            if (Input.touchCount > 0)
            {
                //왼칸을 누르는 경우 (4번타일)
                if ((myTouch[0].position.x > 0) && (myTouch[0].position.x < 110.0f) && (myTouch[0].position.y > 200.0f) && (myTouch[0].position.y < 300.0f))
                {
                    transform.Translate(-1.9f, 0, 0);
                    key = -0.8f;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(-1.9f, 0);
                    Debug.Log(beforechar);
                }

                //오른쪽칸을 누르는 경우 (6번타일)
                if ((myTouch[0].position.x > 150.0f) && (myTouch[0].position.x < 300.0f) && (myTouch[0].position.y > 200.0f) && (myTouch[0].position.y < 300.0f))
                {
                    transform.Translate(1.9f, 0, 0);
                    key = 0.8f;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(1.9f, 0);
                    Debug.Log(beforechar);
                }

                //아래쪽칸을 누르는 경우 (8번타일)
                if ((myTouch[0].position.x > 100.0f) && (myTouch[0].position.x < 150.0f) && (myTouch[0].position.y > 100.0f) && (myTouch[0].position.y < 200.0f))
                {
                    transform.Translate(0, -2.55f, 0);
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy));
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(0, -2.55f);
                    Debug.Log(beforechar);
                }

                //위칸을 누르는 경우 (2번타일)
                if ((myTouch[0].position.x > 100.0f) && (myTouch[0].position.x < 150.0f) && (myTouch[0].position.y > 300.0f) && (myTouch[0].position.y < 500.0f))
                {
                    transform.Translate(0, 2.55f, 0);
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(0, 2.55f);
                    Debug.Log(beforechar);
                }



            }

        }
        //캐릭터가 6번위치에 있는경우

        if ((transform.position.x > 1.0f) && (transform.position.x < 2.0f) && (transform.position.y > 1.0f) && (transform.position.y< 2.0f))
        {
            if (Input.touchCount > 0)
            {
                //왼칸을 누르는 경우 (5번타일)
                if ((myTouch[0].position.x > 100.0f) && (myTouch[0].position.x < 200.0f) && (myTouch[0].position.y > 200.0f) && (myTouch[0].position.y < 300.0f))
                {
                    transform.Translate(-1.9f, 0, 0);
                    key = -0.8f;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(-1.9f, 0);
                    Debug.Log(beforechar);
                }

                //아래쪽칸을 누르는 경우 (9번타일)
                if ((myTouch[0].position.x > 150.0f) && (myTouch[0].position.x < 200.0f) && (myTouch[0].position.y > 200.0f) && (myTouch[0].position.y < 280.0f))
                {
                    transform.Translate(0, -2.55f, 0);
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy));
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(0, -2.55f);
                    Debug.Log(beforechar);
                }

                //위칸을 누르는 경우 (3번타일)
                if ((myTouch[0].position.x > 150.0f) && (myTouch[0].position.x < 200.0f) && (myTouch[0].position.y > 300.0f) && (myTouch[0].position.y < 500.0f))
                {
                    transform.Translate(0, 2.55f, 0);
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(0, 2.55f);
                    Debug.Log(beforechar);
                }


            }

        }

        //캐릭터가 7번위치에 있는경우

        if ((transform.position.x > -2.2f) && (transform.position.x < -1.0f) && (transform.position.y < -1.0f) && (transform.position.y > -2.0f))
        {
            if (Input.touchCount > 0)
            {
                //위칸을 누르는 경우 (4번타일)
                if ((myTouch[0].position.x > 0) && (myTouch[0].position.x < 110.0f) && (myTouch[0].position.y > 200.0f) && (myTouch[0].position.y < 280.0f))
                {
                    transform.Translate(0, 2.55f, 0);
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(0, 2.55f);
                    Debug.Log(beforechar);
                }

                //오른쪽칸을 누르는 경우 8번타일)
                if ((myTouch[0].position.x > 100.0f) && (myTouch[0].position.x < 150.0f) && (myTouch[0].position.y > 100.0f) && (myTouch[0].position.y < 200.0f))
                {
                    transform.Translate(1.9f, 0, 0);
                    key = 0.8f;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(1.9f, 0);
                    Debug.Log(beforechar);
                }

            }

        }

        //캐릭터가 8번위치에 있는경우

        if ((transform.position.x > -0.15f) && (transform.position.x < 1.0f) && (transform.position.y < -1.0f) && (transform.position.y > -2.0f))
        {
            if (Input.touchCount > 0)
            {
                //왼칸을 누르는 경우 (7번타일)
                if ((myTouch[0].position.x > 0) && (myTouch[0].position.x < 110.0f) && (myTouch[0].position.y > 100.0f) && (myTouch[0].position.y < 200.0f))

                {
                    transform.Translate(-1.9f, 0, 0);
                    key = -0.8f;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(-1.9f, 0);
                    Debug.Log(beforechar);
                }

                //오른쪽칸을 누르는 경우 (9번타일)
                if ((myTouch[0].position.x > 150.0f) && (myTouch[0].position.x < 200.0f) && (myTouch[0].position.y > 100.0f) && (myTouch[0].position.y < 200.0f))
                {
                    transform.Translate(1.9f, 0, 0);
                    key = 0.8f;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(1.9f, 0);
                    Debug.Log(beforechar);
                }

                //위칸을 누르는 경우 (5번타일)
                if ((myTouch[0].position.x > 100.0f) && (myTouch[0].position.x < 150.0f) && (myTouch[0].position.y > 200.0f) && (myTouch[0].position.y < 300.0f))
                {
                    transform.Translate(0, 2.55f, 0);
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(0, 2.55f);
                    Debug.Log(beforechar);
                }



            }

        }
        //캐릭터가 9번위치에 있는경우

        if ((transform.position.x > 1.0f) && (transform.position.x < 2.0f) && (transform.position.y < -1.0f) && (transform.position.y > -2.0f))
        {
            if (Input.touchCount > 0)
            {
                //왼칸을 누르는 경우 (8번타일)
                if ((myTouch[0].position.x > 100.0f) && (myTouch[0].position.x < 150.0f) && (myTouch[0].position.y > 100.0f) && (myTouch[0].position.y < 200.0f))
                {
                    transform.Translate(-1.9f, 0, 0);
                    key = -0.8f;
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(-1.9f, 0);
                    Debug.Log(beforechar);
                }

                //위칸을 누르는 경우 (6번타일)
                if ((myTouch[0].position.x > 150.0f) && (myTouch[0].position.x < 300.0f) && (myTouch[0].position.y > 200.0f) && (myTouch[0].position.y < 280.0f))
                {
                    transform.Translate(0, 2.55f, 0);
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
                    nowchar = transform.position;
                    Debug.Log(nowchar);
                    beforechar = nowchar - new Vector2(0, 2.55f);
                    Debug.Log(beforechar);
                }



            }



        }



        */











        
        /*
    
     
        if(input ==1)
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1.9f, 0, 0);
            key = -0.8f;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
            nowchar = transform.position;
            Debug.Log(nowchar);
            beforechar = nowchar - new Vector2(-1.9f, 0);
            Debug.Log(beforechar);
            // Debug.Log(SkillDirector2.instance.Fire());
            // Debug.Log(SkillDirector.instance.Wind());
            Debug.Log("플레이어 x위치: " + myTouch[0].position.x + ", 플레이어 y위치" + myTouch[0].position.y);

        }
        if(input == 2)
        //if ( ((myTouch[0].position.x > transform.position.x ) && (myTouch[0].position.x > 80.0f) ) && (myTouch[0].position.y >= 100.0f) )
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1.9f, 0, 0);
            key = 0.8f;
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
            nowchar = transform.position;
            Debug.Log(nowchar);
            beforechar = nowchar - new Vector2(1.9f, 0);
            Debug.Log(beforechar);
            // Debug.Log(SkillDirector2.instance.Fire());
            //Debug.Log(SkillDirector.instance.Wind());
            Debug.Log("플레이어 x위치: " + myTouch[0].position.x + ", 플레이어 y위치" + myTouch[0].position.y);
         }

        if(input ==4)
        //if((myTouch[0].position.y > transform.position.y) && (myTouch[0].position.x > 0) && myTouch[0].position.y > 100.0f )
        //if (touchY > 600.0f)  
        //if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(0, 2.55f, 0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy), transform.position.z);
            nowchar = transform.position;
            Debug.Log(nowchar);
            beforechar = nowchar - new Vector2(0, 2.55f);
            Debug.Log(beforechar);
            // Debug.Log(SkillDirector2.instance.Fire());
            // Debug.Log(SkillDirector.instance.Wind());
        }
        //if (touchY < 200.0f )

        if(input==3)
        //if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(0, -2.55f, 0);
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, minx, maxx), Mathf.Clamp(transform.position.y, miny, maxy));
            nowchar = transform.position;
            Debug.Log(nowchar);
            beforechar = nowchar - new Vector2(0, -2.55f);
            Debug.Log(beforechar);
            //    Debug.Log(SkillDirector2.instance.Fire());
            // Debug.Log(SkillDirector.instance.Wind());
        }

        




    */


        if (key != 0)
                                            {
                                                transform.localScale = new Vector3(key, 0.8f, 1);
                                            }

                                        }
                                    }

                                
