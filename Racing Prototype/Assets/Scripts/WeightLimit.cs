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

    public GameObject destroyedEffect;
    private int effectNumRng;

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
                    effectNumRng = Random.Range(5,10);
                    for (int i = 0; i < effectNumRng; i++)
                    {
                        Instantiate(destroyedEffect,new Vector3(transform.position.x - Random.Range(-10,0),transform.position.y,transform.position.z - Random.Range(0,10)),Quaternion.identity);
                    }

                    gameObject.SetActive(false);
                }
            }

        }

    }
}
