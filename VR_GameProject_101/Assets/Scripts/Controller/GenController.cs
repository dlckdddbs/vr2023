using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenController : MonoBehaviour
{
    public GameObject Monstertemp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if(Physics.Raycast(cast, out hit))      //out 인수로 hit에 ray값 검출된 값을 넣어준다.
            {
                if(hit.collider.tag == "Ground")
                {
                    GameObject temp = (GameObject)Instantiate(Monstertemp);
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);
                }
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);

                Debug.Log("Hit => " + hit.collider.name);
            }
        }
    }
}
