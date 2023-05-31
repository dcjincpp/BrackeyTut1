using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Put Rigidbody to this parameter in unity
    public Rigidbody rb;
    public float forwardForceZ = 2000f;
    public float sideForce = 500f;

    // Update is called once per frame
    // Use FixedUpdate when dealing with physics
    void FixedUpdate()
    {
        // deltaTime makes sure update intervals are the same across
        //all systems
        // add force in x, y, z direction
        rb.AddForce(0, 0, forwardForceZ * Time.deltaTime);

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }

        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }
    }
}
