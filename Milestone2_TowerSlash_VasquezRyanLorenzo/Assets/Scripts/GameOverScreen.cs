using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public GameObject Canvas;

    public void Setup()
    {
        Canvas.SetActive(true);
    }

    public void RestartButton()
    {
        SpawnerManager.Instance.Start();
        //SceneManager.LoadScene("SampleScene");
    }
}
