using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCsharp_2 : MonoBehaviour
{
    // Start is called before the first frame update
    
    byte b;
    int i ;

    long j;

    string k;

    double L;
    void Start()
    {
        ChangeNumberType();
        ChangeNumberExplicitType() ;
        TutorialTest() ;
        TutorialTest_1() ;
        TutorialTest_2() ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeNumberType()
    {
        b=10;
        j=i=b;
        Debug.Log("這是"+i);
        Debug.Log("這是j"+j);

    }
    void ChangeNumberExplicitType()
    {
        b=10;
        i =(int)b;
        j = (long)i;
        Debug.Log("顯性轉換"+i+j);//得到:顯性轉換1010，不適因為i跟j的type不同，是因為前面是字串，所以延續下來也是字串。
        k = j.ToString();
        Debug.Log(k+k);
    }

    void TutorialTest()
    {
        L = 50;
        i=(int)L;
        Debug.Log(L.GetType());

    }

    void TutorialTest_1()
    {
      k = "123";
      i = Convert.ToInt32(k); //剛剛這個一直失敗，是因為我沒有載入using System;
      Debug.Log(i);
    }

    void TutorialTest_2()
    {
     k="223";
     i = Convert.ToInt32(k);//Convert
     Debug.Log(i);
     k="224";
     i = int.Parse(k);//Parse
     Debug.Log(i);
     string M="224";
     int N;
     if(int.TryParse(M,out N))
     {
      Debug.Log("轉換成功"+N);  
     }
     else
     {
        Debug.Log("轉換失敗");
     }
     
    }
}
