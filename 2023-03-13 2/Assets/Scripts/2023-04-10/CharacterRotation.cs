using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotation : MonoBehaviour
{
    float rotSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
                                               //프레임마다 속도가 1% 씩 줄어드는 수식
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10000;
        }

        transform.Rotate(0, this.rotSpeed * Time.deltaTime, 0);         //캐릭터를 y축이 회전하는 형태로 돌린다.
                                                                        //time delta 값은 프레임이 변경되어도 일정한 값을 유지해서 돌리게 한다.

        rotSpeed *= 0.99f;
    }
}
