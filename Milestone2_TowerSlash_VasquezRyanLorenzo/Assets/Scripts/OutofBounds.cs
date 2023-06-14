using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        SpawnerManager.Instance.RemoveEnemyFromList(gameObject);
    }
}
