using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JosSpawner : MonoBehaviour
{
    public List<GameObject> Enemies;

    public GameObject Spawnpoint;

    public float Spawninterval;

    public float Wavessize;

    public bool Incooldown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Enemies.Count);
        if (Wavessize != 0 && !Incooldown)
        {
            Debug.Log(Incooldown);
            Incooldown = true;
            Instantiate(Enemies[Random.Range(0, Enemies.Count)], Spawnpoint.transform);
            Wavessize--;
            StartCoroutine(Waittimer());
        }
    }

    IEnumerator Waittimer()
    {
        
        yield return new WaitForSeconds(Spawninterval);
        
        Incooldown = false;
        Debug.Log(" test" );
        
    }
}