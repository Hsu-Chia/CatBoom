using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCsharp1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        countScript();
        countScript_2();
        countScript_3();
        countScript_4();
        countScript_5();
        countScript_6();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void countScript()
    {
        int a = 1;
        int b = 2;
        int c;
        c = a+b;
        Debug.Log("這是a+b="+c);
        c = a-b;
        Debug.Log("這是a-b="+c);
        c = a*b;
        Debug.Log("這是a*b="+c);
        c = a/b;
        Debug.Log("這是a/b="+c);
        c = a%b;
        Debug.Log("這是a%b="+c);
        c=++a;
        Debug.Log("這是++a="+c);
        c = --a;
        Debug.Log("這是--a="+c);

    }
    
    void countScript_2()
    {
        int a = 1;
        int b;
        b=a++;
        Debug.Log("a++="+a);
        Debug.Log(b);
        a = 1;
        b=a--;
        Debug.Log("a--="+a);
        Debug.Log(b);
        a = 1;
        b= ++a;
        Debug.Log("++a="+a);
        Debug.Log(b);
        a = 1;
        b= --a;
        Debug.Log("--a="+a);
        Debug.Log(b);

    }

    void countScript_3()
    {
        int a = 21;
        int b = 10;
        if(a==b)
        {
            Debug.Log("line1-a = b");
        }
        else
        {
            Debug.Log("line1-a 不等於b");
        }
        if(a<b)
        {
           Debug.Log("line2-a小於b"); 
        }
        else
        {
            Debug.Log("line2-a不小於b"); 
        }
        if(a>b)
        {
           Debug.Log("line3-a大於b"); 
        }
        else
        {
            Debug.Log("line3-a不大於b"); 
        } 

        a = 5;
        b = 20;
        if(a<=b)
        {
            Debug.Log("Line4-a小於或等於b");
        }       
        else
        {
            Debug.Log("Line5-b小於或等於b");
        }
    }
    void countScript_4()
    {
        bool a = true;
        bool b = true;
        if(a&&b)
        {
            Debug.Log("Line1-條件為真");
        }
        if(a||b)
        {
            Debug.Log("Line2-條件為真");
        }
        a = false;
        b = true;
        if(a&&b)
        {
            Debug.Log("Line 3 - 条件为真");

        }
        else
        {
            Debug.Log("Line 3 -條件不為真");
        }
        if(!(a&&b))
        {
            Debug.Log("Line4-條件為真");
        }  
    }   

    void countScript_5()
    {
        int a = 60;
        int b = 30;
        int c = 0;

        c = a&b;
        Debug.Log("Line 1 - c 的值是"+c);

        c = a|b;
        Debug.Log("Line 2 - c 的值是"+c);

        c = a^b;
        Debug.Log("Line 3 - c 的值是"+c);

        c = ~a;
        Debug.Log("Line 4 - c 的值是"+c);

        c = a<<2;
        Debug.Log("Line 5 - c 的值是"+c);

        c = a>>2;
        Debug.Log("Line 6 - c 的值是"+c);

    }  

    void countScript_6()
    {
        int a =21;
        int c;
        c = a;
        Debug.Log("Line 1 - =  c 的值 ="+c);//c=a的值
        c +=a;
        Debug.Log("Line 2 - += c 的值 ="+c);//c=c+a的值
        c-=a;
        Debug.Log("Line 3 - -=  c 的值 ="+c);
        c*=a;
        Debug.Log("Line 4 - *=  c 的值 = "+c);
        c/=a;
        Debug.Log("Line 5 - /=  c 的值 ="+c);
        c = 200;
        c %= a;
        Debug.Log("Line 6 - %=  c 的值="+c);
        c<<=2;
        Debug.Log("Line 7 - <<=  c 的值 = "+c);
        c>>=2;
        Debug.Log("Line 8 - >>=  c 的值 ="+c);
        c &= 2;
        Debug.Log("Line 9 - &=  c 的值 ="+c);
        c^=2;
        Debug.Log("Line 10- ^=  c 的值 ="+c);
        c|=2;
        Debug.Log("Line 11- |=  c 的值 ="+c);
    }
    
    void countScript_8()
    {
      Debug.Log("int 的大小是"+sizeof(int)); 
      Debug.Log("short 的大小是"+sizeof(short)); 
      Debug.Log("double 的大小是"+sizeof(double)); 

      int a,b;
      a = 10;
      b = (a == 1)?20:30;
      Debug.Log("b 的值是 "+b);
      b = (a == 10) ? 20 : 30;
      Debug.Log("b 的值是 "+b);

    }


}
