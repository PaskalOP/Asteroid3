using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroids3;
using static UnityEngine.GridBrushBase;

public class PoolAsteroids: MonoBehaviour 
{
    private Stack<AsteroidView> _pool;
    private FactoryAsteroid _factoryAsteroid;
    private List<string> _asteroidTyp;
    public GameObject _parentobject;

    public PoolAsteroids (GameObject parentobject, FactoryAsteroid factoryAsteroid, List<string> asteroidTyp)
    {
        _parentobject = parentobject;
        _factoryAsteroid = factoryAsteroid;
        _asteroidTyp = asteroidTyp;
        
    }

    public void FullPool(int Count)
    {
        _pool = new Stack<AsteroidView>(Count);
        
        for (int i = 0; i < Count; i++)
        {
            _pool.Push(Get());
        }

    }

    public AsteroidView Get()
    {
        AsteroidView asteroid;
        asteroid = FactoryAsteroid.CreateAsteroids(new Health(100f, 100f), _parentobject.transform.position,
            _asteroidTyp[Random.Range(0,3)], _parentobject.transform);
        asteroid.gameObject.SetActive(false);
        return asteroid;
    }

    public AsteroidView SetAsteroid()
    {
       
        AsteroidView asteroid = _pool.Pop();
        asteroid.gameObject.SetActive(true);
       
        return asteroid;
    }

    public void ReturnElement(AsteroidView asteroid,GameObject parent)
    {
      
            asteroid.gameObject.SetActive(false);
            asteroid.transform.position = parent.transform.position;
            _pool.Push(asteroid);
         
    }

}
