using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupCounter : MonoBehaviour
{
    public Text pickupCountText;
    public Text winText;

    public int maxNumPickups = 10;

    public int numCollectedPickups = 0;

    public string pickupMessage = "Number of collected Pickups: ";

    private void Update()
    {
        string pickupString = pickupMessage + numCollectedPickups.ToString();
        pickupCountText.text = pickupString;

        if(numCollectedPickups >= maxNumPickups)
        {
            //pickupCountText.text = "YOU WIN!";
            winText.enabled = true;
        }
    }
}
