using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroids3;

public class BilderBullet : MonoBehaviour
{
    [SerializeField] private GameObject _view;

    private void ComponentBuilder()
    {
        var componentBuilder = new GameObject()
            .GetOrAddComponent<Rigidbody>()
            .GetOrAddComponent<Collider>();

    }
}


// класс создания обьекта и компонентов 
public static class GameObjectBullet
{
    public static GameObject GetOrAddComponent<T>(this GameObject gameObject) where T: Component
    {
        var result = gameObject.GetComponent<T>();
        if (!result)
        {
            gameObject.AddComponent<T>(); 
        }
        return gameObject;
    }
}