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
    public GameObject effect;
    public bool isObject = false;
    public bool explodeOnCont;

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
        if (isObject)
        {
            if (effect != null) Instantiate(effect, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }



        

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player" && isObject)
        {
            Explode();
        }
        else if (collision.collider.tag == "Obstacle" && isObject && explodeOnCont)
        {
            Explode();
        }
    }

}
