using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumpTruckAbility : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject dumpObject;
    public GameObject dropPoint;

    public float maxCooldown = 3f;
    private float cooldown = 0;

    // Update is called once per frame
    void Update()
    {
        DumpAbility();
    }


    public void DumpAbility()
    {

        if (Input.GetKeyDown("q") && cooldown <= 0f)
        {

            Instantiate(dumpObject,dropPoint.transform.position,Quaternion.identity);
            cooldown = maxCooldown;
        }


        if (cooldown >= 0) cooldown -= 1 * Time.deltaTime;

    }

}
