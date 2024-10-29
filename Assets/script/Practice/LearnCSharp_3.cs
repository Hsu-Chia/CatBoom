using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearnCSharp2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        judgeSection();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void judgeSection()
    {
        int a = 10;
        if(a ==10)
        {
            Debug.Log("a等於10喔");
        }
        Debug.Log("a的值為="+a);
    }

    
}
