using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Asteroids3;


public class SpawnPoint: MonoBehaviour 
{
   
   private PlayerView _player;
   private Transform target;

    private void Awake()
    {
        _player = FindObjectOfType<PlayerView>();
    }
    public void Update()
    {
        target = _player.transform; 
        transform.LookAt(target);

    }
    
}
