﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoombaMovement : MonoBehaviour
{
    public float obstacleCheckDistance = 0.6f;
    public float moveSpeed = 10;

    public float groundCheckDistance = 0.5f;

    public float gravity = 40;

    bool isGrounded;

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

        if (obstacleInTheWay)
        {
            moveDirection = -moveDirection;
        }

        MoveInDirection(moveDirection, moveSpeed);
    }

    private void SetVerticalMovement()
    {
        isGrounded = Physics.Raycast(transform.position, new Vector3(0, -1, 0), groundCheckDistance);

        //if (isGrounded == false)
        //if (isGrounded != true)
        if (!isGrounded)
        {
            MoveInDirection(new Vector3(0, -1, 0), gravity);
        }
    }


    void MoveInDirection(Vector3 moveVector, float speedMultiplier)
    {
        Vector3 deltaVector = moveVector * speedMultiplier;
        targetVelocity += deltaVector;
    }
}
