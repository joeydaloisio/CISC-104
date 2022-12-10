﻿using System;
using System.Numerics;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Red Ball Collision Manager Function");

        // Homework: Do something interesting here
        if (OtherBall.GetComponent<GreenBallCollisionManager>() != null)
        {
            Debug.Log("Red Collided With Green");
        }
    }
}

