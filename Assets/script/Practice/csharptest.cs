using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csharptest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       csharptest.sayhello(new string[] { "hello", "i will kill you" });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

static void sayhello(string[] args)
{
    foreach (string arg in args)
    {
        Debug.Log(arg);
    }
}
}
