using System;
using System.Numerics;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public GameObject redBallPrefab;
    public GameObject plane;

    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        // Homework: Do something interesting here
        if (OtherBall.GetComponent<RedBallCollisionManager>() != null)
        {
            Debug.Log("Green Collided With Red");

            // Since the blue ball collided with the yellow ball, we will make a green one.
            Instantiate(redBallPrefab, plane.transform);
        }
    }
}
