using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int health = 3;
    public GameOverScreen gameOverScreen;
    public TMP_Text healthCount;

    public GameObject enemy;
    public Enemy enemyScript;

    public bool powerActivated;

    private void Start()
    {
        //To Display Health Count
        healthCount.text = "HP: " + health;
    }

    private void OnTriggerEnter(Collider other)
    {
         //Subtracts health for every collision
         health--;
         healthCount.text = "HP: " + health;

        //When health is 0, Player dies
        if (health <= 0)
        {
            Destroy(gameObject);
            gameOverScreen.Setup();
        }

    }
}
