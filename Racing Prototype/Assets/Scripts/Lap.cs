﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lap : MonoBehaviour
{
   public int checkpointAmt;

   void OnTriggerEnter(Collider other)
   {
      if (other.GetComponent<truckLap>())
      {
         truckLap Truck = other.GetComponent<truckLap>();

         if (Truck.checkpointNum == checkpointAmt)
         {
            Truck.checkpointNum = 0;
            Truck.lapNum += 1;

            Debug.Log(Truck.lapNum);
         }
      }
   }
}
