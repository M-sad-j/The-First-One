using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody Rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //?void Start()
    //{
        //Debug.Log("Hello, Wolrd!");
        //Rb.AddForce(0, 200, 500);
    //}

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(0, 0, 1070 * Time.deltaTime);
    }
}
