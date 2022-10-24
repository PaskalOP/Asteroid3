using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroids3;


public class MoveAsteroid
{
    public  AsteroidView _asteroid;

    public MoveAsteroid(AsteroidView asteroid)
    {
        _asteroid = asteroid;
    }
    public void MoveAsteriod()
    {
        _asteroid.transform.position += _asteroid.transform.forward * _asteroid.Speed * Time.fixedDeltaTime;
    }

}
