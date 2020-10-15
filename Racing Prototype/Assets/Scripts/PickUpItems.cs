using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder;


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



        DisplayNameText();
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
    public GameObject displayMesh;
    public DisplayPickupList meshList;
    public GameObject effect;
    public GameObject explodeEffect;

    // Update is called once per frame
    void Update()
    {

        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
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
                    var inst = Instantiate(meshList.pickupList[0],displayMesh.transform.position,Quaternion.identity);
                    inst.transform.parent = gameObject.transform;
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
                    var inst1 = Instantiate(meshList.pickupList[0], displayMesh.transform.position, Quaternion.identity);
                    inst1.transform.parent = gameObject.transform;
                    break;

                case 1:
                    pickupName = "Block Rain";
                    var inst2 = Instantiate(meshList.pickupList[1], displayMesh.transform.position, Quaternion.identity);
                    inst2.transform.parent = gameObject.transform;
                    break;

                case 2:
                    pickupName = "EXPLOSION!!!";
                    var inst3 = Instantiate(meshList.pickupList[2], displayMesh.transform.position, Quaternion.identity);
                    inst3.transform.parent = gameObject.transform;
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
