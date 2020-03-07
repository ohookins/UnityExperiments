using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float speed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // control position with arrows and variable to control speed
        //transform.position += transform.right * Input.GetAxis("Horizontal") * speed;
        //transform.position += transform.up * Input.GetAxis("Vertical") * speed;

        // control scale of object with left/right and variable to control rate of change
        transform.localScale +=
        new Vector3(Input.GetAxis("Horizontal") * speed,
        Input.GetAxis("Horizontal") * speed,
        Input.GetAxis("Horizontal") * speed);
    }
}
