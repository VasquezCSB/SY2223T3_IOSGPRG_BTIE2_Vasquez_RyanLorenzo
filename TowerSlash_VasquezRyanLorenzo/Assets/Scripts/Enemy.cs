using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float _speed;//5
    public Rigidbody rb;

    int randomizer;

    public GameObject player;
    public Player playerScript;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerScript = player.GetComponent<Player>();
        rb.velocity = Vector3.down * _speed;

    }

    //For when powerup is activated
    public void ActivatePowerUp()
    {
        randomizer = Random.Range(0, 100);

        if (randomizer <= 3)
        {
            playerScript.health += 1;
            playerScript.healthCount.text = "HP: " + playerScript.health;
        }
    }

}
