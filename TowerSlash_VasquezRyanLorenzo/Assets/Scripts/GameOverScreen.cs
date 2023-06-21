using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject player;
    public GameObject coroutine;
    public DashGauge dashGauge;

    public void Setup()
    {
        Canvas.SetActive(true);
    }

    public void RestartButton()
    {
        SpawnerManager.Instance.DeleteEnemies();
        player.SetActive(true);
        player.GetComponent<Player>().health = 3;
        dashGauge.dashMeter = 0;
        coroutine.gameObject.SetActive(true);
        coroutine.GetComponent<SpawnManager>().StartSpawn();
        player.GetComponent<Player>().healthCount.text = "HP: " + player.GetComponent<Player>().health;
        Canvas.SetActive(false);


    }
}
