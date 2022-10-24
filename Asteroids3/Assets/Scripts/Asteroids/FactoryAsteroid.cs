using System.Collections;
using System.Collections.Generic;
using Asteroids3;
using UnityEngine;

public class FactoryAsteroid : MonoBehaviour
{
    public Health _health;
    public AsteroidView _asteroid;
    List<string> asteroidTyp;

    

    public static AsteroidView CreateAsteroids(Health health, Vector3 spawnposition, string asteroidsList, Transform parent)
    {
        var asteroid = Instantiate(Resources.Load<AsteroidView>($"{asteroidsList}"), spawnposition, parent.rotation, parent);
        asteroid._health = health;
        return asteroid;

    }
}
