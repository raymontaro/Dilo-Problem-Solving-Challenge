using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speedX;
    public float speedZ;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();


        rb.AddForce(new Vector3(speedX, 0, speedZ), ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
