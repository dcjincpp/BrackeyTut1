using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Put Rigidbody to this parameter in unity
    public Rigidbody rb;

    // Update is called once per frame
    // Use FixedUpdate when dealing with physics
    void FixedUpdate()
    {
        // deltaTime makes sure update intervals are the same across
        //all systems
        //          x, y, z
        rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
