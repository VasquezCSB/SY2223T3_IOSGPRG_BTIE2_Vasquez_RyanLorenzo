using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class RangedWeapons : MonoBehaviour
{
    [SerializeField] private int _ammo;

    public void Initialize(int ammo)
    {
        _ammo = ammo;
    }

    public virtual void Shoot()
    {
        Debug.Log("Thing");
    }

}
