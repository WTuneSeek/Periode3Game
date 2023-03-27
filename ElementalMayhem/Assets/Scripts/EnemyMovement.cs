using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 3f; // Enemy movement speed
    private Transform player; // Reference to player transform

    private void Start()
    {
        // Find the player object by its tag
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        // Calculate the direction towards the player
        Vector2 direction = player.position - transform.position;
        direction.Normalize();

        // Move towards the player
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
