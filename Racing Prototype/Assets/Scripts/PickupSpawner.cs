using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        pickupPoints = GameObject.FindGameObjectsWithTag("PickUpPoint");

        pickupSpawn();
    }

    public GameObject[] pickupPoints;
    private GameObject[] findPickups;

    public GameObject pickupPos;
    public GameObject pickupNeg;

    public GameObject effect;


    // Update is called once per frame
    void Update()
    {
  

    }

    public void pickupSpawn()
    {
        findPickups = GameObject.FindGameObjectsWithTag("Pickup");
        if (findPickups != null)
        {
            for (int i = 0; i < findPickups.Length; i++)
            {
                Destroy(findPickups[i]);
            }
        }


        int rng;
        for (int i = 0; i < pickupPoints.Length; i++)
        {
            rng = Random.Range(0,2);
            if (rng == 0)
            {
                Instantiate(pickupPos, pickupPoints[i].transform.position, pickupPoints[i].transform.rotation);
                Instantiate(effect,pickupPoints[i].transform.position,Quaternion.identity);
                Debug.Log("Spawned good");
            }
            else if (rng == 1)
            {
                Instantiate(pickupNeg, pickupPoints[i].transform.position, pickupPoints[i].transform.rotation);
                Instantiate(effect, pickupPoints[i].transform.position, Quaternion.identity);
                Debug.Log("Spawned bad");
            }
            


        }
    }
}
