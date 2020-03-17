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

    public float groundCheckDistance = 0.5f;


    [Header("Debug values")]
    public float verticalVelocity;

    public bool isGrounded;

    float horizontalInput;

    Vector3 targetVelocity;


    void FixedUpdate()
    {
        targetVelocity = new Vector3(0, 0, 0);

        SetHorizontalMovement();
        SetVerticalMovement();

        GetComponent<Rigidbody>().velocity = targetVelocity;
    }


    void SetHorizontalMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Vector3 horizontalMoveVector = new Vector3(horizontalInput, 0, 0);

        MoveInDirection(horizontalMoveVector, moveDistancePerSecond);
    }


    void SetVerticalMovement()
    {
        // Check if grounded
        isGrounded = Physics.Raycast(transform.position, new Vector3(0, -1, 0), groundCheckDistance);

        // Trigger Jump
        bool spaceIsPressedDown = Input.GetKeyDown(KeyCode.Space);
        if (spaceIsPressedDown)
        {
            TryToJump();
        }

        // set jumpVelocityDecrease
        float jumpVelocityDecrease = high_JumpVelocityDecrease;
        bool spaceIsPressed = Input.GetKey(KeyCode.Space);
        if (spaceIsPressed)
        {
            if (verticalVelocity > 0)
            {
                jumpVelocityDecrease = low_JumpVelocityDecrease;
            }
        }

        // apply jumpVelocityDecrease to verticalVelocity
        verticalVelocity -= jumpVelocityDecrease * Time.fixedDeltaTime;

        // Clamp verticalVelocity to -maxFallSpeed in negative direction
        if (verticalVelocity < -maxFallSpeed)
        {
            verticalVelocity = -maxFallSpeed;
        }

        // Clamp verticalVelocity to 0 if grounded
        if (isGrounded)
        {
            if (verticalVelocity < 0)
            {
                verticalVelocity = 0;
            }
        }

        // Use verticalVelocity to change targetPosition in y direction
        MoveInDirection(new Vector3(0, 1, 0), verticalVelocity);
    }

    void TryToJump()
    {
        if (isGrounded)
        {
            verticalVelocity = initialJumpVelocity;
        }
    }

    void MoveInDirection(Vector3 moveVector, float speedMultiplier)
    {
        Vector3 deltaVector = moveVector * speedMultiplier;
        targetVelocity += deltaVector;
    }
}
