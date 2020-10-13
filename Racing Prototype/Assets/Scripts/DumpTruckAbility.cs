using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DumpTruckAbility : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = GetComponent<RigidbodyMovement>();
    }

    public RigidbodyMovement myPlayer;

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
        if (myPlayer.player == "Player1")
        {
            if (Input.GetKeyDown(KeyCode.LeftShift) && cooldown <= 0f)
            {

                Instantiate(dumpObject, dropPoint.transform.position, Quaternion.identity);
                cooldown = maxCooldown;
            }

        }

        if (myPlayer.player == "Player2")
        {
            if (Input.GetKeyDown("b") && cooldown <= 0f)
            {

                Instantiate(dumpObject, dropPoint.transform.position, Quaternion.identity);
                cooldown = maxCooldown;
            }

        }


        if (cooldown >= 0) cooldown -= 1 * Time.deltaTime;

    }

}
