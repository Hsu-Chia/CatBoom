using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCsharp_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CountSize();
        GameobjectTest();
        objectTest();
        // DynamicTest();
         StringTest();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CountSize()
    {
        Debug.Log(sizeof(int));
    }
    
    void GameobjectTest()
    {
                // 創建一個新的 GameObject
        GameObject obj1 = new GameObject("Object1");
        // GameObject obj2 = obj1; // 將 obj1 的引用賦值給 obj2

        // 修改 obj2 的名稱
        // obj2.name = "ChangedObject";

        // Debug.Log("obj1 name: " + obj1.name); // 輸出: ChangedObject
        // Debug.Log("obj2 name: " + obj2.name); // 輸出: ChangedObject
    }
    void objectTest()
    {
        object myObject = 42; 
        int number = (int)myObject;
        Debug.Log(number);
    }
    // void DynamicTest()
    // {
    //     dynamic mydynamic =14;
    //     Debug.Log(mydynamic+50);
    //     mydynamic = "你好中國";
    //     Debug.Log(mydynamic);
    // }
    void StringTest()
    {
        string greeting = "Hello";
        greeting+="World";
        Debug.Log(greeting);

    }

}
