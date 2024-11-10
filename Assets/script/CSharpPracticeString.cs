using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CSharpPracticeString : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void topic_1()
    {
        string text = "HelloWorld";
        int length = text.Length;
        Debug.Log("字串長度" + length);
    }
    void topic_2()
    {
        string text = "HelloWorld";
        char character = text[0];
        Debug.Log("第一個字元" + character);
    }
    void topic_3()//Substring：提取子字串
    {
        string text = "Hello,Unity";
        string subtext = text.Substring(0,5);// 從索引 0 開始，提取 5 個字元
        Debug.Log("子字串:" + subtext);
    }
    void topic_4 ()
    {
        string text = "apple,banana,orange";
        string[] fruits = text.Split(',');
        foreach (string fruit in fruits)
        {
            Debug.Log(fruit);
        }
    }
    void topic_5()
    {
        string hello ="Hello";
        string world ="world";
        string result = hello + world;
        Debug.Log(result);
    }
    void topic_6()
    {
        int score = 0;
        string message = string.Format("Your Score is:{0}",score);
        string message_1 = $"Your score is {score}";
        Debug.Log(message_1);
    }
    void topic_7()
    {
        string text = "Hello,world";
        string newText = text.Replace("World","Unity");
        Debug.Log(newText);
    }
    void topic_8()
    {
        string text="Hello,unity";
        string newText = text.Remove(5,1);
        Debug.Log(newText);
    }

    void topic_9()
    {
        string text ="Hello,Unity";
        bool containUnity = text.Contains(text);
        Debug.Log(containUnity);

    }
    void topic_10()
    {
        string text = "Hello,Unity";
        bool startwithHello = text.StartsWith("Hello");
        bool endwithUnity = text.EndsWith("Unity");
        Debug.Log(startwithHello);
        Debug.Log(endwithUnity);
    }
    void topic_11()
    {
        string text ="Hello,Unity";
        string upperText = text.ToUpper();
        string lowerText = text.ToLower();
        Debug.Log(upperText);
        Debug.Log(lowerText);
    }

    void topic_12()
    {
        string text ="Hello,Unity";
        string trimedText = text.Trim();
        Debug.Log(trimedText);
    }

    void topic13()
    {
        string numberstring="123";
        int number = int.Parse(numberstring);
        Debug.Log(number);

        // int number = 123;
        // string text = number.ToString();
        // Debug.Log(text); // 輸出 "123"
    }

    void topic14()
    {
        string text1 = "Hello";
        string text2 = "hello";
        bool isEqual = text1.Equals(text2);
        Debug.Log("兩個字串相等嗎？" + isEqual); 
        bool isEqualIgnoreCase = text1.Equals(text2, StringComparison.OrdinalIgnoreCase);
        Debug.Log("忽略大小寫相等嗎？" + isEqualIgnoreCase); // 輸出 True

    }
}
