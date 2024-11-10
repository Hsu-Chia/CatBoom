using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CSharpPractice : MonoBehaviour
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
        Debug.Log("hello： Alexandra Abramov");
    }

    void topic_2(int a ,int b)
    {
        int result = a + b;
        Debug.Log(result);
        result = a / b;
        Debug.Log(result);
    }
    void topic_3()
    {
        Debug.Log(-1 + 4 * 6);
        Debug.Log(( 35+ 5 ) % 7);
        Debug.Log(14 + -4 * 6 / 11);
        Debug.Log(2 + 15 / 6 * 1 - 7 % 2);
    }

    void topic_4(int a ,int b)
    {
        int result = a;
        a=b;
        b=result;
        Debug.Log($"a:{a},b:{b}");
    }

    void topic_5(int a ,int b,int c)
    {
        int Result = a*b*c;
        Debug.Log(Result);
    }

    void topic_6(int a ,int b)
    {
        int result = a+b;
        Debug.Log(result);
        result = a-b;
        Debug.Log(result);
        result = a*b;
        Debug.Log(result);
        result = a/b;
        Debug.Log(result);
        result = a%b;
        Debug.Log(result);

    }

    void topic_7(int a)
    {
        for (int i =0; i <= 10; i++)
        {
            int result = a*i;
            Debug.Log(result);
        }

    }

    void topic_9(int a,int b,int c,int d)
    {
        int average = (a+b+c+d)/4;
        Debug.Log($"a:{a},b:{b},c:{c},d:{d}+average:{average}");
    }
    void topic_9_1()
    {
        int[] numbers = { 10,15,20,30};
        int score =0;
        for (int i = 0;i < numbers.Length; i++)
        {
            score+=numbers[i];
        }
        float average =(float)score/numbers.Length;

        Debug.Log($"{string.Join(",",numbers)}+average:{average}");
    }

    void topic_10(int a,int b,int c)
    {
        int result = (a+b)*c;
        Debug.Log(result);
        int result_1 = a*b+b*c;
        Debug.Log(result_1);
    }
    void topic_10_1(int a,int b,int c)
    {
        int[]numbers= { a,b,c};
        int result = (numbers[0]+numbers[1])*numbers[2];
        int result_1 = (numbers[0]*numbers[1])+ (numbers[1]*numbers[2]);
        Debug.Log($"{result_1},{result}");
        
    }

    void topic_11 (int a)
    {
        Debug.Log($"您看起來的年齡超過{a}");
    }

    void topic_12(int a)
    {
        Debug.Log($"{a} {a} {a} {a}");
        Debug.Log($"{a}{a}{a}{a}");
        Debug.Log($"{a} {a} {a} ");
        Debug.Log($"{a} {a}{a}{a}{a}");
    }
//     void topic_12(int num)//c#有writeline可以比較簡單寫
// {
//     // 使用格式化字串顯示，第一行有空格
//     Console.WriteLine("{0} {0} {0} {0}", num);
    
//     // 第二行無空格
//     Console.WriteLine("{0}{0}{0}{0}", num);
// }
    void topic13(int a)
    {
        Debug.Log($"{a}{a}{a}");
        for (int i = 0; i < 3; i++)
        {
            Debug.Log($"{a} {a}");
            
        }
        Debug.Log($"{a}{a}{a}");
    }

    void topic13_1(int a)
    {
        int columms = 5;
        int row = 3;
        for (int i = 0;i<row;i++)
        {
            string line = "";
            for (int j = 0;j<columms;j++)
            {
                if(i ==0||i==row-1||j==0||j==columms-1)
                {
                    line+=a;
                }
                else
                {
                    line+="";
                }
            }
        Debug.Log(line);
        }

    }

    void topic14(double a)//建議使用double因為9/5會有小數點
    {
        double k = a+273.15;
        double h = (a*9)/5+32;
        Debug.Log($"{k}&{h}");

    }
    void topic15()
    {
        string sentence = "w3resource";
        string newsentence_1 = sentence.Remove(2,1);
        string newsentence_2 = sentence.Remove(9,1);
        string newsentence_3 = sentence.Remove(1,1);
        Debug.Log(newsentence_1);
        Debug.Log(newsentence_2);
        Debug.Log(newsentence_3);

    }
    void topic16(string text)
    {
        if (text.Length <1)
        {
            Debug.Log("這樣是錯誤的喔");
            return;
        }
        char first = text[0];
        char final = text[text.Length-1];
        string newText = final+text.Substring(1,text.Length-2)+first;
        Debug.Log(newText);
    }

    void topic16_1(string text)
    {
        if(text.Length <1)
        {
            Debug.Log("這樣是錯誤的喔");
            return ;
        }
        char first =text[0];
        char final = text[text.Length-1];
        string newText = final+text.Substring(1,text.Length-2)+first;
        Debug.Log(newText);

    }

    void topic17(string text)
    {
        char first =text[0];
        string newText =first+text+first;
        Debug.Log(newText);
    }

    bool topic18(int a,int b)
    {
        if((a<0&&b>0)||(a>0&&b<0) )
        {
            return true;
        }
          return false;
    }

void topic19(int a, int b)
{
    int sum = a + b;
    if (a == b)
    {
        Debug.Log(3 * sum);
    }
    else
    {
        Debug.Log(sum);
    }
}

void topic20(int a, int b)
{
    int difference = a - b;
    int absoluteDifference = Math.Abs(difference);

    if (a > b)
    {
        Debug.Log( 2 * absoluteDifference);
    }
    else
    {
        Debug.Log(absoluteDifference);
    }
}

bool topic21(int a,int b)
{
    if(a==20||b==20||a+b==20)
    {
        return true ;
    }
    return false ;
}

bool topic22(int a)
{
    if (Math.Abs(100-a)<=20||Math.Abs(200-a)<=20)
    {
        return true ;
    }
    return false;
}

void topic23(string a)
{
    string newtext = a.ToLower();
    Debug.Log(newtext);
}

void topic24(string text)
{
    string[] words = text.Split(' '); // 使用空格字符作為分割依據
    string longestWord = "";
    foreach (string word in words)
    {
        if (word.Length > longestWord.Length)
        {
            longestWord = word;
        }
    }
    Debug.Log("The longest word is: " + longestWord);
}
void topic25()
{
    for(int i =0;i<=99;i+=2)
    {
        Debug.Log(i);
    }
}

void topic26()
{
    int result=0;
    for (int i =1;i<=500;i++)
    {
        result += i;
    }
    Debug.Log(result);
        
}
}
