using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy : Enemy
{
    public Transform target;
    public float chaseRaidus;
    public float attackRadius;
    public Transform homePosition;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        CheckDistance();
    }

    void CheckDistance () 
    {
        if(Vector3.Distance(target.position, transform.position) <= chaseRaidus && Vector3.Distance(target.position, transform.position) > attackRadius) 
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D (Collider2D collision) 
    {
        //if(collision.tag == "Player") 
        {
        }
    }
}