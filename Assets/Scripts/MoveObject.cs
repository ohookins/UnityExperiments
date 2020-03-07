using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // move based on up/down and left/right arrows
        //transform.position += transform.up * Input.GetAxis("Vertical");
        //transform.position += transform.right * Input.GetAxis("Horizontal");

        // rotate left and right
        //transform.Rotate(Vector3.up * 25 * Input.GetAxis("Horizontal"));

        // bigger or smaller with left/right arrows
        transform.localScale +=
            new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Horizontal"), Input.GetAxis("Horizontal"));
    }
}
