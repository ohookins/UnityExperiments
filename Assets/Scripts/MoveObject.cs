using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public int speed = 25;
    float xPosition;
    float yPosition;
    float zPosition;

    Rigidbody rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        MoveCube();
    }

    void MoveCube()
    {
        xPosition = Input.GetAxis("Horizontal") * speed;
        yPosition = Input.GetAxis("Jump") * speed;
        zPosition = Input.GetAxis("Vertical") * speed;
        rb.AddForce(xPosition, yPosition, zPosition);
    }
}
