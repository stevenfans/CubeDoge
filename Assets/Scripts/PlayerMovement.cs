using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb; 
    public float forwardForce = 2000f; 
    public float sidewayForce = 750f; 

    // Update is called once per frame
    // FixedUpdate works better with physics
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce*Time.deltaTime);  

        if(Input.GetKey("d")){
            rb.AddForce(sidewayForce*Time.deltaTime,0,0,ForceMode.VelocityChange); 
        }
        if(Input.GetKey("a")){
            rb.AddForce(-sidewayForce*Time.deltaTime,0,0,ForceMode.VelocityChange); 
        }
        if(Input.GetKey("a")==false && Input.GetKey("d")==false)
        {
            rb.velocity = new Vector3(0,rb.velocity.y, rb.velocity.z);
        }
        if(rb.position.y <= -1f){
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
