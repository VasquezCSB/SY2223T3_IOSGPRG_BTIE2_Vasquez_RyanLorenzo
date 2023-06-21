using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerManager : Singleton<SpawnerManager>
{
    [SerializeField] private GameObject enemyPrefabRight_Red;
    [SerializeField] private GameObject enemyPrefabRight_Green;
    [SerializeField] private GameObject player;
    [SerializeField] private DashGauge dashGauge;

    [SerializeField] private Transform spawnedParent;
    [SerializeField] public List<GameObject> enemies; //for dashGauge

    public void RemoveEnemyFromList(GameObject enemy)
    {
        enemies.Remove(enemy);
    }

    public void Start()
    {
        DeleteEnemies();
    }

    //For spawning certain amount of enemies
    public void SpawnEnemies(int count)
    {
        for (int i = 0; i < count; i++)
        {
            //Dictates the location of entities on ecludrian plane
            float xPosition = 0;
            float randomYPosition = Random.Range(12, 30);
            float zPosition = 0;

            Vector3 randomPosition = new Vector3(xPosition, randomYPosition, zPosition);

            float randEnemy = Random.Range(1, 2);

            if(randEnemy == 1)
            {
                //Assigning a reference to modify
                GameObject enemy = Instantiate(enemyPrefabRight_Red, randomPosition, Quaternion.identity);
                enemy.transform.parent = spawnedParent; //Parent

                //Refers to enemy prefabs, then Enemy refers to Enemy Script, then gets the player declaration which should be equal to player
                enemy.GetComponent<Enemy>().player = player;
                enemy.GetComponent<Enemy_Swipe>().dashGauge = dashGauge;
                enemies.Add(enemy);
            }

            if(randEnemy == 2)
            {
                //Assigning a reference to modify
                GameObject enemy = Instantiate(enemyPrefabRight_Green, randomPosition, Quaternion.identity);
                enemy.transform.parent = spawnedParent; //Parent
                enemy.GetComponent<Enemy>().player = player;
                enemies.Add(enemy);
            }
            

        }
    }

    public void DeleteEnemies()
    {

        foreach(GameObject enemy in enemies) 
        {
            enemies.Remove(enemy);

        }
    }

}
