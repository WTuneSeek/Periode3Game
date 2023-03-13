using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public int currHealth;
    public int maxHealth;

    [Space]
    public int expGiven;
    
    [Space]
    public int knockbackForce;
    
    [Space]
    public int hitTimer;
    public int hitTime;
    public bool isHit;
    public Rigidbody2D rb;
    public GameObject expOrb;
    public bool isDead;

}
