using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody obj;
    public float forwardForce = 2000f;
    public float sideForce = 500f;

    // Marked this as fixed update as we're working on physics
    void FixedUpdate()
    {
        obj.AddForce(0, 0, forwardForce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            obj.AddForce(sideForce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(Input.GetKey("a"))
        {
            obj.AddForce(-sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (obj.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
