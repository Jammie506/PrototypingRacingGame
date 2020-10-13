using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float radius = 3f;
    public float power = 3f;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Explode()
    {

        Collider[] colliders = Physics.OverlapSphere(transform.position,radius);

        foreach (Collider hit in colliders)
        {
            Rigidbody otherRB = hit.GetComponent<Rigidbody>();

            if (otherRB != null)
            {
                otherRB.AddExplosionForce(power, transform.position + new Vector3(0,-3,0), radius);
            }


        }

    }

}
