using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids3
{
    public class Player : MonoBehaviour
    {
        
        private PlayerController _playerController;
        private PlayerMove _playerMove;
        [SerializeField] private PlayerView _player;

        private void Awake()
        {
           
            _playerController = new PlayerController();
            _playerMove = new PlayerMove();
        }
       
        
        void Update()
        {
            _playerController.UpdateControllerMove(_playerMove, _player);
        }
    }
}

