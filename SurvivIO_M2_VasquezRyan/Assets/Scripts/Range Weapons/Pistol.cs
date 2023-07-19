using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : RangedWeapons
{
    public override void Shoot()
    {
        base.Shoot();
        Debug.Log("THing");
    }
}
