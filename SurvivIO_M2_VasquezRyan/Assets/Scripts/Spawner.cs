using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Weapons
    [SerializeField] private GameObject _pistolPrefab;
    [SerializeField] private GameObject _automaticRiflePrefab;
    [SerializeField] private GameObject _shotgunPrefab;

    //Ammo
    [SerializeField] private GameObject _pistolAmmoPrefab;
    [SerializeField] private GameObject _automaticRifleAmmoPrefab;
    [SerializeField] private GameObject _shotgunAmmoPrefab;

    //Enemy
    [SerializeField] private GameObject _enemyPrefab;

    //Coords for Spawning
    private float _randomX;
    private float _randomY;
    private Vector3 _randPos;
    
    private void Start()
    {
        //pistol
        for(int i = 0; i < 2; i++)
        {
            //Gets Random Position of instance
            _randomX = Random.Range(-7, 7);
            _randomY = Random.Range(-4, 4);
            _randPos = new Vector3(_randomX, _randomY, 0);

            //Instantiates the object 
            GameObject pistolGO = Instantiate(_pistolPrefab, _randPos, Quaternion.identity);
            pistolGO.transform.parent = transform; // transform is spawner
            Pistol pistol = pistolGO.GetComponent<Pistol>();

            pistol.Initialize(7);
        }

        //auto rifle
        for (int i = 0; i < 2; i++)
        {
            //Gets Random Position of instance
            _randomX = Random.Range(-8, 8);
            _randomY = Random.Range(-5, 5);
            _randPos = new Vector3(_randomX, _randomY, 0);

            //Instantiates the object 
            GameObject automaticRifleGO = Instantiate(_automaticRiflePrefab, _randPos, Quaternion.identity);
            automaticRifleGO.transform.parent = transform; // transform is spawner
            AutomaticRifle automaticRifle = automaticRifleGO.GetComponent<AutomaticRifle>();

            automaticRifle.Initialize(7);
        }

        //shotgun
        for (int i = 0; i < 2; i++)
        {
            //Gets Random Position of instance
            _randomX = Random.Range(-7, 7);
            _randomY = Random.Range(-4, 4);
            _randPos = new Vector3(_randomX, _randomY, 0);

            //Instantiates the object 
            GameObject shotgunGO = Instantiate(_shotgunPrefab, _randPos, Quaternion.identity);
            shotgunGO.transform.parent = transform; // transform is spawner
            Shotgun shotgun = shotgunGO.GetComponent<Shotgun>();

            shotgun.Initialize(7);
        }

        //pistol ammo
        for (int i = 0; i < 2; i++)
        {
            //Gets Random Position of instance
            _randomX = Random.Range(-5, 5);
            _randomY = Random.Range(-6, 6);
            _randPos = new Vector3(_randomX, _randomY, 0);

            //Instantiates the object 
            GameObject pistolAmmoGO = Instantiate(_pistolAmmoPrefab, _randPos, Quaternion.identity);
            pistolAmmoGO.transform.parent = transform; // transform is spawner
            Pistol_Ammo pistolAmmo = pistolAmmoGO.GetComponent<Pistol_Ammo>();

        }

        //auto rifle ammo
        for (int i = 0; i < 2; i++)
        {
            //Gets Random Position of instance
            _randomX = Random.Range(-4, 4);
            _randomY = Random.Range(-7, 7);
            _randPos = new Vector3(_randomX, _randomY, 0);

            //Instantiates the object 
            GameObject automaticRifleAmmoGO = Instantiate(_automaticRifleAmmoPrefab, _randPos, Quaternion.identity);
            automaticRifleAmmoGO.transform.parent = transform; // transform is spawner
            ARif_Ammo automaticRifleAmmo = automaticRifleAmmoGO.GetComponent<ARif_Ammo>();

        }

        //shotgun ammo
        for (int i = 0; i < 2; i++)
        {
            //Gets Random Position of instance
            _randomX = Random.Range(-8, 8);
            _randomY = Random.Range(-5, 5);
            _randPos = new Vector3(_randomX, _randomY, 0);

            //Instantiates the object 
            GameObject shotgunAmmoGO = Instantiate(_shotgunAmmoPrefab, _randPos, Quaternion.identity);
            shotgunAmmoGO.transform.parent = transform; // transform is spawner
            Shotgun_Ammo shotgunAmmo = shotgunAmmoGO.GetComponent<Shotgun_Ammo>();

        }

        //enemy
        for (int i = 0; i < 2; i++)
        {
            //Gets Random Position of instance
            _randomX = Random.Range(-9, 9);
            _randomY = Random.Range(-5, 5);
            _randPos = new Vector3(_randomX, _randomY, 0);

            //Instantiates the object 
            GameObject enemyGO = Instantiate(_enemyPrefab, _randPos, Quaternion.identity);
            enemyGO.transform.parent = transform; // transform is spawner
            Enemy enemy = enemyGO.GetComponent<Enemy>();

        }

    }
}
