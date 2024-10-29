using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCSharp_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        judgeSection();
        judgeSection_1();
        judgeSection_2();
        judgeSection_3();
        judgeSection_4();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void judgeSection()
    {
        int a = 30;
        if(a <= 20)
        {
            Debug.Log("a小於20喔");
        }
        else
        {
            Debug.Log("a大於20喔");
        }
        Debug.Log("a的值為="+a);
    }
    void judgeSection_1()
    {
        int a = 100;
        if(a == 20)
        {
            Debug.Log("a是20喔");
        }
        else if(a == 40)
        {
            Debug.Log("a是40喔");
        }
        else if(a == 60)
        {
            Debug.Log("a是60喔");
        }        
        else
        {
            Debug.Log("沒有匹配的值喔");
        }
        Debug.Log("a的值為="+a);
    }

    void judgeSection_2()
    {
        int a = 100;
        int b = 200;
        if (a==100)
        {
            if(b == 200)
            {
                Debug.Log("a的值是100，且b的值是200");
            }
        }
        Debug.Log ("a的準確值為="+a+"\n"+"b的準確值為="+b);
    }
    void judgeSection_3()
    {
        int day = 0;
        switch (day)
        {
            case 1:
            Debug.Log("Monday");
            break;
            case 2:
            Debug.Log("Tuesday");
            break ;
            case 3:
            Debug.Log("Wednesday");
            break;
            case 4:
            Debug.Log("Thursday");
            break;
            case 5:
            Debug.Log("Friday");
            break;
            case 6:
            Debug.Log("Saturday");
            break;
            case 7:
            Debug.Log("Sunday");
            break;
            default:
            Debug.Log("Everday is happy day");
            break;
        }

    }
    void judgeSection_4()
    {
        int a = 100;
        int b = 200;
        switch (a)
        {
            case 100:
            Debug.Log("這是外部switch的一部份");
            switch (b)
            {
                case 200:
                Debug.Log("這是內部switch的一部份");
                break;
            }
            break;
        }
        Debug.Log ("a的準確值為="+a+"\n"+"b的準確值為="+b);
    }
}
