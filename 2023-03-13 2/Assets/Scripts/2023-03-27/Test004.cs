using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test004 : MonoBehaviour
{

    public int hp = 180;
    public Text Hptext;
    public Text HpStatus;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HpStatus.text = hp.ToString();
        if (Input.GetMouseButtonDown(0))
        {
            hp += 10;
        }

        if (Input.GetMouseButtonDown(1))
        {
            hp -= 10;
        }




        if (hp <= 50)
        {
            //debug.log("����");
            Hptext.text = "����";
        }

        else if (hp >= 200)
        {
            //Debug.Log("����");
            Hptext.text = "����";
        }

        else
        {
            //Debug.Log("��� ");
            Hptext.text = "���";
        }
    }
}
