using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelTank : MonoBehaviour
{
    public float maxFuel = 100;
    public float fuelDepletionPerSecond = 25;

    public float currentFuel;

    private void Start()
    {
        currentFuel = maxFuel;
    }

    public bool HasFuelLeft()
    {
        bool hasFuel = currentFuel > 0;

        return hasFuel;
    }




    public void UseFuel()
    {
        currentFuel = currentFuel - fuelDepletionPerSecond * Time.deltaTime;

        if(currentFuel < 0)
        {
            currentFuel = 0;
        }
    }
}
