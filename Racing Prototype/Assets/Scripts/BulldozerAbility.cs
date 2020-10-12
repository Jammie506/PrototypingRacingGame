using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulldozerAbility : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject createObstacle;

 //   public Collider myDozerCol;

   // public GameObject createObject;
    public GameObject createPoint;
    public GameObject dozerEffect;

    public float maxCooldown = 3f;
    private float cooldown = 0f;
    public float chargeUpMax = 2f;
    private float chargeup = 0f;

    // Update is called once per frame
    void Update()
    {
        scrapeGround();    
        



    }

    public void scrapeGround()
    {

        if (Input.GetKey("e"))
        {

            dozerEffect.SetActive(true);

            chargeup += 1 * Time.deltaTime;

        }
        else
        {
            dozerEffect.SetActive(false);
            

        }

        if (Input.GetKeyUp("e") && cooldown < 0 && chargeup >= chargeUpMax)
        {



            Instantiate(createObstacle, createPoint.transform.position, Quaternion.identity);

            chargeup = 0;
            cooldown = maxCooldown;
        }
        if (cooldown >= 0)
        {
            cooldown -= 1 * Time.deltaTime;
        }

        if (Input.GetKey("e") != true)
        {
            chargeup = 0;
        }


    }
}
