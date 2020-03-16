using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovement : MonoBehaviour
{
    public float moveDistancePerSecond = 8;
    public float maxFallSpeed = 9;

    public float initialJumpVelocity = 20;

    public float low_JumpVelocityDecrease = 20;
    public float high_JumpVelocityDecrease = 80;

    float verticalVelocity;

    float horizontalInput;

    Vector3 targetPosition;


    void FixedUpdate()
    {
        targetPosition = transform.position;

        SetHorizontalMovement();
        SetVerticalMovement();

        GetComponent<Rigidbody>().MovePosition(targetPosition);
    }

    void SetHorizontalMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Vector3 horizontalMoveVector = new Vector3(horizontalInput, 0, 0);

        MoveInDirection(horizontalMoveVector, moveDistancePerSecond);
    }

    void SetVerticalMovement()
    {
        bool spaceIsPressedDown = Input.GetKeyDown(KeyCode.Space);
        if (spaceIsPressedDown)
        {
            Jump();
        }

        MoveInDirection(new Vector3(0, 1, 0), verticalVelocity);

        float jumpVelocityDecrease = high_JumpVelocityDecrease;
        bool spaceIsPressed = Input.GetKey(KeyCode.Space);
        if (spaceIsPressed)
        {
            if (verticalVelocity > 0)
            {
                jumpVelocityDecrease = low_JumpVelocityDecrease;
            }
        }

        verticalVelocity -= jumpVelocityDecrease * Time.fixedDeltaTime;

        if (verticalVelocity < -maxFallSpeed)
        {
            verticalVelocity = -maxFallSpeed;
        }
    }

    void Jump()
    {
        verticalVelocity = initialJumpVelocity;
    }

    void MoveInDirection(Vector3 moveVector, float speedMultiplier)
    {
        Vector3 deltaVector = moveVector * Time.fixedDeltaTime * speedMultiplier;
        targetPosition += deltaVector;
    }
}
