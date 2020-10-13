using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public int checkInd;

    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<truckLap>())
        {
            truckLap Truck = other.GetComponent<truckLap>();

            if (Truck.checkpointNum == checkInd + 1 || Truck.checkpointNum == checkInd - 1)
            {
                Truck.checkpointNum = checkInd;

                Debug.Log(checkInd);
            }
        }
    }
}
