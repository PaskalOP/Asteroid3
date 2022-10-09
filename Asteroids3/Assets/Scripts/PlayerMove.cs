using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids3
{
    public class PlayerMove 
    {
        private float Speed = 100;
       

        public void Move(PlayerView player, float x, float y, float z)
        {
            if (player._rigidbody)
            {
                player._rigidbody.AddForce(new Vector3(x, y, z) * Speed);
            }
            
            else Debug.Log("Не найден Риджет боди");
        }
    }
}

