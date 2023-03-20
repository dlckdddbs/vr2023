using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test003 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string str1 = "Happy";
        string str2 = "birthday";
        string message;
        message = str1 + str2;
        Debug.Log(message);


        str1 += str2;
        Debug.Log(str1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
