using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void SayHello()
    {
        Debug.Log("Hello");
    }

    void callname(string name)
    {
        Debug.Log("Hello"+name);
    }

    int add(int a, int b)
    {
        int c = a + b;
        return c;
    }
    // Start is called before the first frame update
    void Start()
    {
        SayHello();
        SayHello();
        callname("TOM");
        callname("SAM");
        Debug.Log(add(5, 5));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
