using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] protected string _name;

    [SerializeField] private int _currentHealth;
    [SerializeField] private int _maxHealth;
    [SerializeField] private float _speed;

    [SerializeField] private RangedWeapons _currentWeapon;

    public virtual void TakeDamage(int damage)
    {
        _currentHealth -= damage;

        //Clamp
        _currentHealth = Mathf.Max(_currentHealth, 0);
    }

    protected virtual void Shoot()
    {
        _currentWeapon.Shoot();
    }

}
