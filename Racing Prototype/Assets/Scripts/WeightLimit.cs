using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeightLimit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float maxWeight = 20;

    Rigidbody[] otherRBs;

    // Update is called once per frame
    void Update()
    {
        


    }

    void CheckObjects()
    {

        foreach (Rigidbody rb in otherRBs)
        {

            
        }


    }


    private void OnCollisionStay(Collision collision)
    {
        
    }
}
