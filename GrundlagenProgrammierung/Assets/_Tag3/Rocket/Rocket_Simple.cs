using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket_Simple : MonoBehaviour
{
    public float turnSpeed = 1;
    public float thrustAcceleration = 0.1f;

    public KeyCode thrustInput;

    float currentSpeed;

    void Update()
    {
        Turn();

        if (Input.GetKey(thrustInput))
        {
            Thrust();
        }

        ApplyMovement();
    }


    private void Turn()
    {
        float turnInput = Input.GetAxis("Horizontal");
        Vector3 turnVector = new Vector3(0, turnInput, 0);

        transform.Rotate(turnVector * turnSpeed);
    }


    void Thrust()
    {
        currentSpeed = currentSpeed + thrustAcceleration;
    }


    private void ApplyMovement()
    {
        Vector3 moveVector = transform.forward * currentSpeed;
        transform.position = transform.position + moveVector;
    }
}
