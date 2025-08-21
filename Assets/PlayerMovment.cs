using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody Rb;
    
    public float forwardForce = 2000f;
    public float SidewaysForce = 500f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //?void Start()
    //{
    //Debug.Log("Hello, Wolrd!");
    //Rb.AddForce(0, 200, 500);
    //}

    // Update is called once per frame
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
