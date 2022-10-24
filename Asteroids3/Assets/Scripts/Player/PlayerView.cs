using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids3
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] public Transform _transform;
        [SerializeField] public Rigidbody _rigidbody;
        [SerializeField] public Collider _collider;
        [SerializeField] public GameObject _gameObject;
        [SerializeField] public Transform _sootPoint;


        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
    }
    
}

