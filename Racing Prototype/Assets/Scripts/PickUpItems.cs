﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUpItems : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        destructiblePaths = GameObject.FindGameObjectsWithTag("GroundDestructible");
        blockRain = GameObject.Find("RainingBlocksEvent").GetComponent<RainBlocks>();

        if (isPositive)
        {
            rng = Random.Range(0,1);    // Available events to pick
        }
        else
        {
            rng = Random.Range(0, 3);   // Available events to pick
        }
    }
    #region Event Variables
    public GameObject[] destructiblePaths;
    [Header("List of events")]
    public RainBlocks blockRain;
    public Bomb explode;
    public GameObject destroyPath;

    public GameObject repairPath;
    #endregion


    byte itemTypeb;
    public bool isPositive; // Defined from seperate prefabs
    private int rng;
    public string pickupName;
    public TextMesh displayName;
    public GameObject effect;
    public GameObject explodeEffect;

    // Update is called once per frame
    void Update()
    {
        DisplayNameText();
        

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            if (isPositive == true)
            {
                PositiveEvent();
            }
            else if (isPositive == false)
            {
                NegativeEvent();
            }


            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }

    private void DisplayNameText()
    {
        if (isPositive)
        {
            switch (rng)
            {
                case 0:
                    pickupName = "Repair All Tracks";
                    break;

                case 1:

                    break;

            }
        }
        else
        {
            switch (rng)
            {
                case 0:
                    pickupName = "Destroy Track";
                    break;

                case 1:
                    pickupName = "Block Rain";
                    break;

                case 2:
                    pickupName = "EXPLOSION!!!";
                    break;
            }
        }
        displayName.text = pickupName;
        // displayName.transform.LookAt(GameObject.Find("Main Camera").transform.position,transform.up);
        // displayName.transform.localRotation = GameObject.Find("Main Camera").transform.rotation;

        displayName.transform.rotation = Quaternion.LookRotation(displayName.transform.position - GameObject.Find("Main Camera").transform.position);

    }

    #region myEvents

    public void NegativeEvent()
    {

    //    int rng = Random.Range(0, 2);

        switch (rng)
        {

            case 0:
                int rngd = Random.Range(0, destructiblePaths.Length);
                destructiblePaths[rngd].SetActive(false);
                break;

            case 1:
                blockRain.spawnBlocks();
                break;

            case 2:
                explode.Explode();
                Instantiate(explodeEffect,transform.position,Quaternion.identity);
                break;


        }

    }

    public void PositiveEvent()
    {
    //    int rng = Random.Range(0, 1);

        switch (rng)
        {

            case 0:

                for (int i = 0; i < destructiblePaths.Length; i++)
                {
                    if (destructiblePaths[i].activeSelf != true)
                        destructiblePaths[i].SetActive(true);
                }

                break;

            case 1:
                break;


        }

    }





    #endregion


}
