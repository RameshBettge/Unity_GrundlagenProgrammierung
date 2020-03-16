using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketControls : MonoBehaviour
{
    public float turnSpeed = 1;
    public float thrustAcceleration = 0.1f;

    public KeyCode thrustInput;

    float currentSpeed;

    FuelTank tank;
    RocketFire fire;

    private void Start()
    {
        tank = GetComponent<FuelTank>();
        fire = GetComponentInChildren<RocketFire>();
    }

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
        if (tank.HasFuelLeft())
        {
            tank.UseFuel();

            currentSpeed += thrustAcceleration;

            fire.isThrusting = true;
        }

    }


    private void ApplyMovement()
    {
        Vector3 moveVector = transform.forward * currentSpeed;
        transform.position = transform.position + moveVector;
    }
}
