using UnityEngine;

public class CubeCollision : MonoBehaviour
{

    public CubeMovement movement;
    public static bool grounded = false;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }

        if(collisionInfo.collider.tag == "Ground")
        {
            grounded = true;
        }
    }
}
