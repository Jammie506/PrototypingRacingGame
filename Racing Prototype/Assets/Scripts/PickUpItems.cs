using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItems : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        eventHolder = GameObject.Find("EventHolder");
    //    itemTypeb = (byte)Random.Range(0, 1);
    /*
        if (itemTypeb == 0)
        {
            isPositive = false;
        }
        else if (itemTypeb == 1)
        {
            isPositive = true;
        }
        */
    }

    byte itemTypeb;
    public bool isPositive;
    public GameObject eventHolder;
    public GameObject effect;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (isPositive == true)
            {
                eventHolder.GetComponent<EventHolder>().PositiveEvent();
            }
            else if (isPositive == false)
            {
                eventHolder.GetComponent<EventHolder>().NegativeEvent();
            }


            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }

}
