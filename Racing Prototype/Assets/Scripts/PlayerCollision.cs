using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public GameObject effect;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player") Instantiate(effect, transform.position, Quaternion.identity);

    }

}
