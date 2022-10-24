using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids3
{
    public class AsteroidView : MonoBehaviour
    {
        [SerializeField] public GameObject _gameObject;
        [SerializeField] public Transform _transform;
        [SerializeField] public Collider _collider;
       
        public Health _health;
        public float Speed;


        private void Start()
        {
            Speed = Random.Range(5, 10);

        }
        public void Update()
        {
            transform.position += transform.forward * Speed * Time.fixedDeltaTime;
        }
    
    }
}

