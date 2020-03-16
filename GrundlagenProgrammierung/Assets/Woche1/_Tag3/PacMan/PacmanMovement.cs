using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacmanMovement : MonoBehaviour
{
    Vector3 moveInput = new Vector3(0, 0, 0);
    public float speed = 0.1f;

    void Update()
    {
        SetMoveInput();
        ApplyMovement();
    }


    void SetMoveInput()
    {
        float inputH = Input.GetAxisRaw("Horizontal");
        float inputV = Input.GetAxisRaw("Vertical");

        if (inputH != 0)
        {
            moveInput = new Vector3(inputH, 0, 0);
        }

        if (inputV != 0)
        {
            moveInput = new Vector3(0, 0, inputV);
        }
    }

    void ApplyMovement()
    {
        transform.position = transform.position + moveInput * speed;
    }
}
