using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaMovement : MonoBehaviour
{
    public float obstacleCheckDistance = 0.6f;
    public float moveSpeed = 10;

    Vector3 targetVelocity;
    Vector3 moveDirection = new Vector3(1, 0, 0);

    void FixedUpdate()
    {
        targetVelocity = new Vector3(0, 0, 0);

        SetHorizontalMovement();
        SetVerticalMovement();

        GetComponent<Rigidbody>().velocity = targetVelocity;
    }

    void SetHorizontalMovement()
    {
        bool obstacleInTheWay = Physics.Raycast(transform.position, moveDirection, obstacleCheckDistance);
        Debug.DrawRay(transform.position, moveDirection * obstacleCheckDistance, Color.magenta);

        if(obstacleInTheWay)
        {
            moveDirection = -moveDirection;
        }

        MoveInDirection(moveDirection, moveSpeed);
    }

    private void SetVerticalMovement()
    {
    }


    void MoveInDirection(Vector3 moveVector, float speedMultiplier)
    {
        Vector3 deltaVector = moveVector * speedMultiplier;
        targetVelocity += deltaVector;
    }
}
