using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody rb;
    private Transform player;
    public float speed = 5.0f; 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player.position, transform.position) > 5.0f)
        {
            Vector3 dierection = (player.position - transform.position).normalized;
            rb.MovePosition(transform.position + dierection * speed * Time.deltaTime);

        }
    }
}
