using UnityEngine;

public class playerScript : MonoBehaviour
{

    public float speed;
    public float sidespeed;

    public Rigidbody rb;
     void FixedUpdate()
    {
        rb.AddForce(0, 0, speed * Time.deltaTime);

        if(Input.GetKey("a")){
            rb.AddForce(-sidespeed, 0, 0);
        }

        if(Input.GetKey("d")){
            rb.AddForce(sidespeed, 0, 0);
        }

    }
}
