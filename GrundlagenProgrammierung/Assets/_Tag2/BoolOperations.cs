using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoolOperations : MonoBehaviour
{
    void Start()
    {
        //bool isGreaterThanF = (1 > 2); // false
        //bool isGreaterThanT = (2 > 1); // true

        //bool isFalse = !true; 

        //// Aufgabe:
        //// Erstellt eine Funktion, die zwei Zahlen annimmt.
        //// Die Funktion soll die Nummer zurück geben,
        //// die größer ist.
        //// dafür benötigt ihr vermutlich zwei if-statements

        //bool isSmallerThanT = (1 < 2); // true
        //bool isSmallerThanF = (2 < 1); // false

        //bool isEqualF = (1 == 2); // false
        //bool isEqualT = (2 == 2); // true

        //bool isNotEqualT = (1 != 1); // false
        //bool isNotEqualF = (1 != 2); // true

        if(transform.position.x < 0)
        {
            Die();
        }
    }

    private void Die()
    {
        throw new NotImplementedException();
    }
}
