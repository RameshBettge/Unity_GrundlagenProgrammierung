using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstFunctions : MonoBehaviour
{
    //public int myInt = 0;
    //public float myFloat;
    //public string myString;

    public int a;
    public int b;

    public int mySum;

    void Update()
    {
        mySum = a + b;

        int sum = AddNumbers(2, 4);
        print(sum);

        float subtractedNum = SubtractNumbers(1, 2);
    }

    private float SubtractNumbers(float a, float b)
    {
        float result = a - b;

        return result;
    }


    private void Start()
    {
        //int result = AddNumbers(2, 4);


        int result = SubtractNumbers(2, 4);

        int product = MultiplyNumbers(3, 3);

        bool iAmGrounded = IsGrounded();


        MoveX(12);
    }

    // Rückgabetyp Name (Parametertyp ParameterName)
    void MoveX (int x)
    {
        transform.position = transform.position + new Vector3(x, 0, 0);
    }

    bool IsGrounded()
    {
        return true;
    }


    int MultiplyNumbers(int a, int b)
    {
        int output = a * b;
        return output;
    }

    int SubtractNumbers(int a, int b)
    {
        int output = a - b;
        return output;
    }


    // wir nehmen zwei zahlen an.
    // wir addieren die zwei gegebenen zahlen.
    // wir geben eine Zahl zurück

    int AddNumbers(int a, int b)
    {
        int sum = a + b;

        return sum;
    }

    void DoNothing()
    {
    }
}
