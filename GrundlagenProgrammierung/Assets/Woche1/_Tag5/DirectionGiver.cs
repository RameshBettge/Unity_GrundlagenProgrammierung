using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionGiver : MonoBehaviour
{
    public Vector3 directionToGive;
    public float speedToGive;

    public MoveInDirection moveInDirection;
    public MoveInDirection moveInDirection2;

    void Update()
    {
        moveInDirection.SetNewDirectionAndSpeed(directionToGive, speedToGive);
        moveInDirection2.SetNewDirectionAndSpeed(directionToGive, speedToGive);
    }
}
