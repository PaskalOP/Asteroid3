using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Asteroids3;
using UnityEngine;
using static UnityEngine.GridBrushBase;

public class SpawnPointsForAsteroids: MonoBehaviour
{
    public GameObject prefab;
    private float spawnRadius = 50f;
    public Transform spawnPoint;
    private PoolAsteroids pool;
    private FactoryAsteroid _factoryAsteroid;
    private List<string> asteroidTyp;
    private int  countOfPool;
    int spawnCount;
    private GameObject parent;
    //private GameObject pointForPool;
    private List<PoolAsteroids> poolsList;
    //private AsteroidView asteroidInPool;
    


    private GameObject PointForPool(GameObject parent)
    {
        GameObject pointForPool; 
        spawnCount--;
        pointForPool = Instantiate(prefab, spawnPoint.position + Random.insideUnitSphere * spawnRadius, Quaternion.identity,
                parent.transform);
        pointForPool.transform.position = new Vector3(pointForPool.transform.position.x, spawnPoint.position.y, pointForPool.transform.position.z);

        return pointForPool;
    }

    IEnumerator StartSetAsteroids(PoolAsteroids pool)
    {
        int countSet = 20;
        GameObject pointForPool = PointForPool(parent);
        while (countSet > 0)
        {
            countSet--;
            yield return new WaitForSeconds(1f);
            AsteroidView asteroidInPool = pool.SetAsteroid();
           yield return new WaitForSeconds(6f);
           pool.ReturnElement(asteroidInPool, pointForPool);
            countSet++;
        }
        
    }
    

    void Start()
    {
        parent = new GameObject();
       // pointForPool = PointForPool(parent);

        poolsList = new List<PoolAsteroids>();
        while (spawnCount > 0)
        {
            
            pool = new PoolAsteroids(PointForPool(parent), _factoryAsteroid, asteroidTyp);
            pool.FullPool(countOfPool);
            poolsList.Add(pool);
            
        }

        
       for (int i = 0; i <=49; i++)
       {
           StartCoroutine(StartSetAsteroids(poolsList[i]));
           
       }
       

    }

    private void Awake()
    {
        _factoryAsteroid = new FactoryAsteroid();
        asteroidTyp = new List<string>();
        asteroidTyp.Add("Asteroid Lava Blue");
        asteroidTyp.Add("Asteroid Lava Red");
        asteroidTyp.Add("Mine Sample 1");
        asteroidTyp.Add("Mine Sample 2");

        countOfPool = 20;
        spawnCount = 50;
        
    }

    private void Update()
    {
       

    }
}

