using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickUp : MonoBehaviour
{
    private Rigidbody2D rb;
    
    
    
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D col)
    {
        GameObject whatHit = col.gameObject;
        if (whatHit.CompareTag("Player"))
        {
            whatHit.GetComponent<PlayerStats>().Heal(2);
            Destroy(gameObject);
        }
    }
}
