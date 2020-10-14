using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
     //   myPos = GetComponent<Vector3>();
    }
    public string player;  // 'Player1' or 'Player2'
    public Rigidbody myRigidbody;
    public Vector3 myPos;
    private float horz, horz2;
    private float vert, vert2;

    public float speed = 100f;
    public float torque = 100f;
    public float maxTorqueSpeed = 0.2f;
    public float rayDist = 1f;

     public float maxVel = 20f;
     public float minVel = -20f;

    void FixedUpdate()
    {
        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        horz2 = Input.GetAxis("Horizontal2");
        vert2 = Input.GetAxis("Vertical2");

        MoveVehicle();
    }

    void MoveVehicle()
    {
        







    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Colliding!");
      //  if (Physics.Raycast(transform.position, Vector3.down, rayDist))
      //  {
            if (player == "Player1")
            {
                myRigidbody.maxAngularVelocity = maxTorqueSpeed;
                if (Input.GetKey("d"))
                {
                    myRigidbody.AddRelativeTorque(Vector3.up * torque, ForceMode.Acceleration);
                }

                if (Input.GetKey("a"))
                {
                    myRigidbody.AddRelativeTorque(Vector3.up * -torque, ForceMode.Acceleration);
                }


                //  myRigidbody.angularVelocity();

                if (myRigidbody.velocity.z < maxVel && myRigidbody.velocity.z > minVel && myRigidbody.velocity.x < maxVel && myRigidbody.velocity.x > minVel)
                {
                    myRigidbody.AddRelativeForce(Vector3.forward * speed * vert * Time.deltaTime, ForceMode.Acceleration);
                }



                // myRigidbody.velocity = transform.forward * speed * vert;
                Debug.Log(myRigidbody.velocity);
            }

      //  }


     //   if (Physics.Raycast(transform.position, Vector3.down, rayDist))
       // {
            if (player == "Player2")
            {
                myRigidbody.maxAngularVelocity = maxTorqueSpeed;
                if (Input.GetKey("l"))
                {
                    myRigidbody.AddRelativeTorque(Vector3.up * torque, ForceMode.Acceleration);
                }

                if (Input.GetKey("j"))
                {
                    myRigidbody.AddRelativeTorque(Vector3.up * -torque, ForceMode.Acceleration);
                }


                //  myRigidbody.angularVelocity();

                if (myRigidbody.velocity.z < maxVel && myRigidbody.velocity.z > minVel && myRigidbody.velocity.x < maxVel && myRigidbody.velocity.x > minVel)
                {
                    myRigidbody.AddRelativeForce(Vector3.forward * speed * vert2 * Time.deltaTime, ForceMode.Acceleration);
                }



                // myRigidbody.velocity = transform.forward * speed * vert;
                Debug.Log(myRigidbody.velocity);
            }

      //  }
    }

}
