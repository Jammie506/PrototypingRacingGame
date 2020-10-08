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

    Rigidbody otherRB;

    // Update is called once per frame
    void Update()
    {
        


    }
    /*
    void CheckObjects()
    {

        foreach (Rigidbody rb in otherRBs)
        {

            
        }


    }
    */

    private void OnCollisionStay(Collision collision)
    {

        if (collision.collider.tag == "Obstacle")
        {
            otherRB = collision.collider.GetComponent<Rigidbody>();
            if (otherRB != null)
            {
                if (otherRB.mass > maxWeight)
                {
                    gameObject.SetActive(false);
                }
            }

        }

    }
}
