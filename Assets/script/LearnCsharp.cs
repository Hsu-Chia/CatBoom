using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCsharp : MonoBehaviour
{
    // Start is called before the first frame update
    double length = 4.5;
    double width=3.5;

    void Start()
    {
       HelloWorld(); 
    //    AcceptDetails();
       Display();
       objectTest();
       Debug.Log(floatAdd(3,5));
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HelloWorld()
    {
        Debug.Log("HelloWorld");
    }

    // void AcceptDetails()
    // {
    //     length = 4.5;
    //     width = 2.5;
    // }

    double GetArea()
    {
        return length*width;
    }

    void Display()
    {
        Debug.Log("Length:"+length);
        Debug.Log("Width:"+width);
        Debug.Log("Area"+GetArea());
    }

    void objectTest()
    {
        object myobject = 5;
        int myInt = (int)myobject;
        Debug.Log("這是"+myInt);
    }

   float floatAdd(float A,float B)
    {
        return A+B;
    }
}
