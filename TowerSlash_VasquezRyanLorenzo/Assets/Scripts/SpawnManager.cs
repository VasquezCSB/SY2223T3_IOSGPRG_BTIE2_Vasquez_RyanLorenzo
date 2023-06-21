using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    //Singleton creates an instance of a class
    //You don't have to reference

    private void Start()
    {
        StartCoroutine(singletonCount());
    }

    public void StartSpawn()
    {
        StartCoroutine(singletonCount());
    }

    IEnumerator singletonCount()
    {
        yield return new WaitForSeconds(Random.Range(3, 5));
        SpawnerManager.Instance.SpawnEnemies(Random.Range(1, 2));
        StartCoroutine(singletonCount());
    }
}
