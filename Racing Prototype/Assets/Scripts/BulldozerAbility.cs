using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulldozerAbility : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = GetComponent<RigidbodyMovement>();
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

    public RigidbodyMovement myPlayer;

    // Update is called once per frame
    void Update()
    {
        scrapeGround();    
        



    }

    public void scrapeGround()
    {
        if (myPlayer.player == "Player1")
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {

                dozerEffect.SetActive(true);

                chargeup += 1 * Time.deltaTime;

            }
            else
            {
                dozerEffect.SetActive(false);


            }

            if (Input.GetKeyUp(KeyCode.LeftShift) && cooldown < 0 && chargeup >= chargeUpMax)
            {



                Instantiate(createObstacle, createPoint.transform.position, Quaternion.identity);

                chargeup = 0;
                cooldown = maxCooldown;
            }
            if (cooldown >= 0)
            {
                cooldown -= 1 * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.LeftShift) != true)
            {
                chargeup = 0;
            }
        }

        if (myPlayer.player == "Player2")
        {
            if (Input.GetKey("b"))
            {

                dozerEffect.SetActive(true);

                chargeup += 1 * Time.deltaTime;

            }
            else
            {
                dozerEffect.SetActive(false);


            }

            if (Input.GetKeyUp("b") && cooldown < 0 && chargeup >= chargeUpMax)
            {



                Instantiate(createObstacle, createPoint.transform.position, Quaternion.identity);

                chargeup = 0;
                cooldown = maxCooldown;
            }
            if (cooldown >= 0)
            {
                cooldown -= 1 * Time.deltaTime;
            }

            if (Input.GetKey("b") != true)
            {
                chargeup = 0;
            }
        }


    }
}
