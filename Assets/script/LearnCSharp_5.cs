using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCSharp_5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WhileScript();//用while迴圈算1加到100
        ForScript();//用for迴圈算1加到100
        WhileScript_1();////用while迴圈表示奇數
        ForScript_1();//用for迴圈表示奇數
        ForScript_2(10);//用for迴圈表示n!
        IfScript_2(10);//用遞迴表示n!(未成功)
        ifscript_3(-50);//用if else表示成績
        switchScript(50);//用switch表示成績範圍
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void WhileScript()
    {
        int a = 0;
        int i = 0;
        while (i <=100)
        {
            a = a+i;
            i++;
        }
        Debug.Log("a的值:"+a);
    }
    void ForScript()
    {
        int a =0;
        for (int i = 0; i <=100; i++)
        {
            a+=i;
        }
        Debug.Log(a);
    }
        void WhileScript_1()
    {
        int i = 1;
        while (i <=100)
        {
            Debug.Log("這是While迴圈的奇數:"+i);
            i=i+2;
        }
    }
    void ForScript_1()
    {
        for (int i = 1; i <=100;i=i+2)
        {
            Debug.Log("這是for迴圈的奇數"+i);
        }
    }
    void ForScript_2(int n)
    {
        int result = 1;
        for (int i = 1; i <=n;i++)
        {
            result = result*i;
        }
        Debug.Log("n!迴圈="+result);
    }
    void IfScript_2(int n)//需要再了解一下遞迴的概念
    {
        if(n<=0)
        {
            return;
        }
        Debug.Log("n!遞迴測試="+n);
        IfScript_2(n-1);
    }

    void ifscript_3(int score)
    {
        if(score == 100||score>=90)
        {
            Debug.Log("你得了A");
        }
        else if (80<=score&&score<90)
        {
            Debug.Log("你得到B");
        }
        else if (70<=score&&score<80)
        {
            Debug.Log("你得到C");
        }
        else if (60<=score&&score<70)
        {
            Debug.Log("你得到D");
        }
        else if (0<=score&&score<60)
        {
            Debug.Log("你得到E");
        }
        else
        {
            Debug.Log("請重新確認成績");
        }         
    }
    void switchScript(int score)
    {
        switch(score)
        {
            case int n when(n == 100||n>=90):
                Debug.Log("你得了A");
                break;
            case int n when(n>=80 && n<90):
                Debug.Log("你得了B");
                break;
            case int n when(n>=70&&n<80):
                Debug.Log("你得了C");
                break;
            case int n when(n>=60&&n<70):
                Debug.Log("你得了D");
                break;
            case int n when(n>=0&&n<60):
                Debug.Log("你得了E");
                break;
            default:
                Debug.Log("請重新確認成績");
                break;          
        }
    }
}
