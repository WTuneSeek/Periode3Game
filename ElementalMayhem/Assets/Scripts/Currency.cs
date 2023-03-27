using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public GameObject player;
    public float timer;

    public bool moveToPlayer;
    public float speed;
    public Rigidbody2D rb;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    public void FixedUpdate()
    {
        if (moveToPlayer == false)
        {
            if (timer < 1)
            {
                timer += Time.fixedDeltaTime;
            }
            else
            {
                moveToPlayer = true;
                rb.gravityScale = 0;
            }
        }

        if (moveToPlayer)
        {
            Vector3 movementVector = player.transform.position - transform.position;
            rb.velocity = movementVector * speed;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerStats>().currMoney += 1;
            Destroy(gameObject);
        }
    }
}

