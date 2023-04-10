using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeSystem : MonoBehaviour
{

    private Vector2 intitialPos;
    public GameObject Character;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) intitialPos = Input.mousePosition;         //������ �� ���콺 ��ġ�� �����Ѵ�.
        if (Input.GetMouseButtonUp(0)) Calculate(Input.mousePosition);              //���콺�� Up �Ǿ��� �� �μ��δ� ���콺 ��ġ�� �Է��ϰ� �ռ��� ȣ���Ѵ�.
            
    }

    void Calculate(Vector3 finalPos)
    {
        float disX = Mathf.Abs(intitialPos.x- finalPos.x);             //disX�� distance�� ���� (�Ÿ�)
        float disy = Mathf.Abs(intitialPos.y - finalPos.y);

        if (disX > 0 || disy > 0)
        {
            if (disX > disy)                    //������� �������� �˻��ؼ� ū������ �Ǵ�.
            {
                if (intitialPos.x > finalPos.x)  Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);  //����
                else Character.transform.position += new Vector3(1.0f, 0.0f, 0.0f);     //������
            }   
            else
            {
                if (intitialPos.y > finalPos.y)
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, -1.0f);  //����
                }
                else
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, 1.0f);     //����
                }
            }
        }

    }
}
