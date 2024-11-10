using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CSharp_Practice_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        topic_1();
        topic_2();
        topic_3_CalculateArea_1(4.0,5.0);
        topic_3_CalculateArea_2(3.0);
        topic_3_CalculateArea_3();
        Topic_4_BMICount(70,150);
        topic_5_word_count("Learning C# is fun and powerful!");
        topic_6_Remove();
        Topic_7_CheckAndLogPrime(7);
        Topic_7_CheckAndLogPrime(10);
        topic_8_triangle();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void topic_1()
    {
        int[] ints={ 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 };
        Array.Reverse(ints);
        int sum = 0;
        int GetHighestNumber = int.MinValue;
        int GetLowestNumber = int.MaxValue;
        foreach (int i in ints)
        {
            if (i > GetHighestNumber)
            {
                GetHighestNumber = i;
            }
            if (i < GetLowestNumber)
            {
                GetLowestNumber = i;
            }
            sum +=i;
        }
        Debug.Log("最大值為:"+GetHighestNumber);
        Debug.Log("最小值為:"+GetLowestNumber);
        Debug.Log("總和為:" + sum);
        Debug.Log("反轉後的陣列為:" + string.Join(", ", ints));//直接輸出ints會出現System.Int32[]是字串的樣式，需住要改成這樣才有辦法顯示正確字串

    }

    void topic_2()
    {
        for (int i = 0;i<=10;i++)
        {
            if (i%2==0)
            {
                continue;
            }
            Debug.Log("for迴圈輸出"+i);
        }

        int b = 0; 
        while(b <=10)
        {
            b++ ;
            if(b == 5)
            {
                break;
            }
            Debug.Log("While迴圈輸出"+b);
        }
        int[] ints ={ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        foreach(int num in ints)
        {
            if(num==7)
            {
                continue ;
            }
            else if(num == 10)
            {
                break ;
            }
             Debug.Log("Foreach 迴圈輸出"+num);
        }

    }

    void topic_3_CalculateArea_1( double Length,double Width)
    {
        double SquareSize ;
        SquareSize = Length*Width;
        Debug.Log("矩形面積為:" + SquareSize);
    
    }

    void topic_3_CalculateArea_2( double Radius)
    {
        double CircleSize ;
        CircleSize = 3.14*Math.Pow( Radius,2);
        Debug.Log("圓形面積為:" + CircleSize);
    
    }

    void topic_3_CalculateArea_3( double side = 5.0)
    {
        double SquareSize_1;
        SquareSize_1 = Math.Pow( side,2);
        Debug.Log("方形面積為:" + SquareSize_1 );

    }

    void Topic_4_BMICount(double weight,double height)
    {
        double heights = height/100;
        double BMICount = weight/Math.Pow( heights,2);
        BMICount =Math.Round(BMICount,1);
        if(BMICount<18.5)
        {
            Debug.Log($"分類過輕,BMI:{BMICount}");
        }
        else if(BMICount>=18.5&&BMICount<24)
        {
            Debug.Log($"分類正常,BMI:{BMICount}");
        }
        else if(BMICount>=24&&BMICount<30)
        {
             Debug.Log($"分類過重,BMI:{BMICount}");
        }
        if(BMICount>=30)
        {
            Debug.Log($"分類肥胖,BMI:{BMICount}");
        }
    }
   
    void topic_5_word_count(string sentence)
    {
        int count = 0;
        string cleanedSentence = sentence.Replace(",", "").Replace(".", "").Replace("!", "").Replace("?", "");
    
         foreach (string word in cleanedSentence.Split(' '))
        {
            if (word.Contains("a"))//這裡是所有有a的單詞都會顯現出來 我一開始寫的是word == "a"
            {
                count++;
            }
        }
        Debug.Log("包含 'a' 的單詞數量: " + count); 
    }

    void topic_6_Remove()//List我不太熟悉 需要多練習
    {
        int[] ints={ 5, 12, 7, 9, 12, 3, 12 };
        List<int> list = new List<int>();
        foreach (int i in ints)
        {
            if(i!=12)
            {
                list.Add(i);
            }
        }
        int[]resultArray =list.ToArray();
        Debug.Log("新陣列"+string.Join(" ",resultArray));

    }

    void Topic_7_CheckAndLogPrime(int number)
    {
        if (IsPrime(number))
        {
            Debug.Log(number + " 是質數");
        }
        else
        {
            Debug.Log(number + " 不是質數");
        }
    }

    bool IsPrime(int number)//用for迴圈進行判斷沒有這樣使用過
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i * i <= number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }


    void topic_8_triangle()
    {
        int Column =5;
        int Row = 9;
        for (int i = 1;i <= Column; i++)
        {
            string line = "";
            for (int j = 1;j <= Row; j++)
            {
                if(i==5||i==4 && 1<j && j<=Row-1||i==3 && 2<j && j<=Row-2||i==2 && 3<j && j<=Row-3||i==1 && 4<j && j<=Row-4)//在<的地方忘記寫=
                {
                    line+="*";
                }
                else
                {
                    line+="  ";//一開始寫的時候中間沒有空格
                }
            }
            Debug.Log(line);
        }
    }


    


}
