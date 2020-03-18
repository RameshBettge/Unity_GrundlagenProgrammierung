using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoopaMovement : MonoBehaviour
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

        Vector3 pitRayOrigin = transform.position + moveDirection * obstacleCheckDistance;
        bool pitInTheWay = !Physics.Raycast(pitRayOrigin, new Vector3(0, -1, 0), groundCheckDistance);


        if (obstacleInTheWay)
        {
            AvoidObstacle();
        }

        if (isGrounded)
        {
            if (pitInTheWay)
            {
                AvoidObstacle();
            }
        }

        MoveInDirection(moveDirection, moveSpeed);

        // Debugging
        Debug.DrawRay(pitRayOrigin, Vector3.down * groundCheckDistance, Color.magenta);
        Debug.DrawRay(transform.position, moveDirection * obstacleCheckDistance, Color.cyan);
    }

    void AvoidObstacle()
    {
        moveDirection = -moveDirection;
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 180, 0);
    }

    private void SetVerticalMovement()
    {
        isGrounded = Physics.Raycast(transform.position, new Vector3(0, -1, 0), groundCheckDistance);
        Debug.DrawRay(transform.position, new Vector3(0, -1, 0) * groundCheckDistance, Color.green);


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
