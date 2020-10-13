using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHolder : MonoBehaviour                    // THIS SCRIPTED IS SCRAPPED THE CODE WILL BE MOVED TO PickUpItems.cs
{
    // Start is called before the first frame update
    void Awake()
    {

        destructiblePaths = GameObject.FindGameObjectsWithTag("GroundDestructible");

    }

    public GameObject[] destructiblePaths;

    public RainBlocks blockRain;
    public GameObject destroyPath;

    public GameObject repairPath;


    // Update is called once per frame
    void Update()
    {
        


    }

    public void NegativeEvent()
    {

        int rng = Random.Range(0,2);

        switch (rng)
        {

            case 0:
            int rngd = Random.Range(0,destructiblePaths.Length);
                destructiblePaths[rngd].SetActive(false);
                break;

            case 1:
                blockRain.spawnBlocks();
                break;



        }

    }

    public void PositiveEvent()
    {
        int rng = Random.Range(0, 1);

        switch (rng)
        {

            case 0 :

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


}
