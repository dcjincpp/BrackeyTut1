using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Put Rigidbody to this parameter in unity
    public Rigidbody rb;
    public float forwardForceZ = 8000f;
    public float sideForce = 120f;

    // Update is called once per frame
    // Use FixedUpdate when dealing with physics
    void FixedUpdate()
    {
        // deltaTime makes sure update intervals are the same across
        //all systems
        // add force in x, y, z direction
        rb.AddForce(0, 0, forwardForceZ * Time.deltaTime);
        // increase speed over time
        forwardForceZ = forwardForceZ + 5f;

        if ( Input.GetKey("d") )
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("a") )
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ( Input.GetKey("space") && CubeCollision.grounded == true)
        {
            rb.AddForce(0, 20, 0, ForceMode.VelocityChange);
            CubeCollision.grounded = false;
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
