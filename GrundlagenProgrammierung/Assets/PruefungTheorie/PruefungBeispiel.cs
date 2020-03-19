using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruefungBeispiel : MonoBehaviour
{
    Vector3 targetPosition;

    void Update()
    {
        //targetPosition = transform.position;

        //ModifyTargetPosition();

        Vector3 someVector = transform.position;

        Vector3 modifiedVector = ModifySomeVector3(someVector);
        //Vector3 modifiedVector = ModifySomeVector3(new Vector3(0, 0, 0));
        //Vector3 modifiedVector = new Vector3(1, 0, 0);

        transform.position = modifiedVector;
    }

    Vector3 ModifySomeVector3(Vector3 givenVector)
    {
        givenVector += new Vector3(1, 0, 0);

        return givenVector;
    }

    void ModifyTargetPosition()
    {
        targetPosition += new Vector3(1, 0, 0);
    }
}
