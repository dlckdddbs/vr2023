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
        if (Input.GetMouseButtonDown(0)) intitialPos = Input.mousePosition;         //눌렸을 때 마우스 위치를 저장한다.
        if (Input.GetMouseButtonUp(0)) Calculate(Input.mousePosition);              //마우스가 Up 되었을 때 인수로는 마우스 위치를 입력하고 합수를 호출한다.
            
    }

    void Calculate(Vector3 finalPos)
    {
        float disX = Mathf.Abs(intitialPos.x- finalPos.x);             //disX는 distance의 약자 (거리)
        float disy = Mathf.Abs(intitialPos.y - finalPos.y);

        if (disX > 0 || disy > 0)
        {
            if (disX > disy)                    //가로축과 세로축을 검사해서 큰것으로 판단.
            {
                if (intitialPos.x > finalPos.x)  Character.transform.position += new Vector3(-1.0f, 0.0f, 0.0f);  //왼쪽
                else Character.transform.position += new Vector3(1.0f, 0.0f, 0.0f);     //오른쪽
            }   
            else
            {
                if (intitialPos.y > finalPos.y)
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, -1.0f);  //뒤쪽
                }
                else
                {
                    Character.transform.position += new Vector3(0.0f, 0.0f, 1.0f);     //앞쪽
                }
            }
        }

    }
}
