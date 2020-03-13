using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInDirection : MonoBehaviour
{
    public Vector3 direction;
    public float speed = 0.01f;

    void Update()
    {
        Move();
    }

    public void SetNewDirectionAndSpeed(Vector3 newDirection, float newSpeed)
    {
        direction = newDirection;
        speed = newSpeed;
    }










    private void Move()
    {
        transform.position += direction * speed;
    }
}
