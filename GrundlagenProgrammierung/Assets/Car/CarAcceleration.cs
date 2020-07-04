using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarAcceleration : MonoBehaviour
{
    [SerializeField]
    float acceleration = 100;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.forward * acceleration, ForceMode.Acceleration);
    }
}
