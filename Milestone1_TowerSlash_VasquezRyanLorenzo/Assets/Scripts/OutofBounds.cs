using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entity Destroyed");
        Destroy(other.gameObject);
    }
}
