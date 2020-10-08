using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        itemTypeb = (byte)Random.Range(0, 1);

        if (itemTypeb == 0)
        {
            isPositive = false;
        }
        else if (itemTypeb == 1)
        {
            isPositive = true;
        }

    }

    byte itemTypeb;
    bool isPositive;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {


            Destroy(gameObject);

        }
    }

}
