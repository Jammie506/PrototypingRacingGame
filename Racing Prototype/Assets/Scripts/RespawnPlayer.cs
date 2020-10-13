﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{

    public GameObject respawn1;
    public GameObject respawn2;
    public GameObject respawn3;
    public GameObject respawn4;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<truckLap>())
        {
            truckLap Truck = other.GetComponent<truckLap>();

            if (Truck.checkpointNum == 0)
            {
                Truck.transform.position = respawn1.transform.position;
            }
            
            if (Truck.checkpointNum == 1)
            {
                Truck.transform.position = respawn2.transform.position;
            }
            
            if (Truck.checkpointNum == 2)
            {
                Truck.transform.position = respawn3.transform.position;
            }
            
            if (Truck.checkpointNum == 3)
            {
                Truck.transform.position = respawn4.transform.position;
            }
        }
    }
}
