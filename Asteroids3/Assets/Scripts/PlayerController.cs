using System.Collections;
using System.Collections.Generic;
using Asteroids3;
using UnityEngine;

namespace Asteroids3
{
    public class PlayerController
    {

        float X;
        float Y;
        float Z;
   

        public void UpdateControllerMove(PlayerMove playerMove, PlayerView player)
        {

            X = Input.GetAxis("Horizontal");
            Y = Input.GetAxis("Jump");
            Z = Input.GetAxis("Vertical");
            playerMove.Move(player,X, Y, Z);

        }
    }
}
    
   

