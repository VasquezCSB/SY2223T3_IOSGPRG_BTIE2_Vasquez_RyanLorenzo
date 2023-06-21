using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        SpawnerManager.Instance.RemoveEnemyFromList(other.gameObject);
        Destroy(other.gameObject);
    }
}
