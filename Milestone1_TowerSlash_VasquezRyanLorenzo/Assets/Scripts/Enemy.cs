using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    /*
    public int _health;
    public int _attack;
    public int _defense;
    */

    public float speed = 3;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.down * speed;

    }

    private void Update()
    {
        
    }
}
