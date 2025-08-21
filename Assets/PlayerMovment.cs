using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody Rb;
    
    public float forwardForce = 2000f;
    public float SidewaysForce = 500f;
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            Rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            Rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
