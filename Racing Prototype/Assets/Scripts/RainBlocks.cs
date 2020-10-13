using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainBlocks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    //    spawnBlocks();
    }
    public GameObject block;

    public int num = 30;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnBlocks()
    {

        for (int i = 0; i < num; i++)
        {

            Instantiate(block,transform.position + new Vector3(Random.Range(-50,50),Random.Range(-10,20),Random.Range(-50,50)),Quaternion.identity);

        }

    }

}
