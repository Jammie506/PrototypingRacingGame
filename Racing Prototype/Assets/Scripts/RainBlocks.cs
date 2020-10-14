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
    public GameObject[] block;
    public float spawnRange = 50;
    private int rng;
    public int num = 30;
    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnBlocks()
    {

        for (int i = 0; i < num; i++)
        {
            rng = Random.Range(0,block.Length);
            Instantiate(block[rng],transform.position + new Vector3(Random.Range(-spawnRange,spawnRange),Random.Range(-10,20),Random.Range(-spawnRange,spawnRange)),Quaternion.identity);

        }

    }

}
