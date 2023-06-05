using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coroutine : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Sprite[] sprites;

    [SerializeField] private bool inRange;
    float timer;

    private void Start()
    {
        StartCoroutine(CO_Timer());
    }

    private IEnumerator CO_Timer()
    {
        while(!inRange)
        {
            yield return new WaitForSeconds(0.3f);
            image.sprite = sprites[Random.Range(0, sprites.Length)];
        }

        image.sprite = sprites[0];
    }
}
