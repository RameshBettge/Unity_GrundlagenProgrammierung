using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstFunctions : MonoBehaviour
{
    void Update()
    {
        int sum = AddNumbers(2, 4);
        print(sum);

        float subtractedNum = SubtractNumbers(1, 2);
    }

    private float SubtractNumbers(float a, float b)
    {
        float result = a - b;

        return result;
    }

    int AddNumbers(int a, int b)
    {
        int sum = a + b;

        return sum; 
    }


}
