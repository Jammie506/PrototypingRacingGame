using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleHealth : MonoBehaviour
{



    public float health = 3;
    public GameObject[] deathEffects;
    public GameObject hitEffect;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            health--;
            Instantiate(hitEffect,transform.position,Quaternion.identity);

            if (health <= 0)
            {

                for (int i = 0; i < deathEffects.Length; i++)
                {
                    Instantiate(deathEffects[i], transform.position, Quaternion.identity);
                }


                Destroy(gameObject);
            }

        }

    }




}
