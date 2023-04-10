using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleTileMap : MonoBehaviour
{
    public GameObject tile_001;
    //public GameObject tile_002;
    // Start is called before the first frame update
    void Start()
    {
        for(int i =0; i<20; i++)
        {
            for(int j=0; j<10; j++)
            {
                GameObject temp = (GameObject)Instantiate(tile_001);        //instantiate 함수는 Prefabs을 생성하는 함수 return 있음 (temp에 입력)
                temp.transform.position = new Vector3(i, 0, j);             //temp 입력받은 오브젝트의 위치 값은 (x => i 이고 z => j)이다
            }

        }
    }

    // Update is called once per frame
   
}
