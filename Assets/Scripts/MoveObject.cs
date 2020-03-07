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
        // move the object to the right
        //transform.position += transform.right;

        // rotate the object around the up axis (y)
        //transform.Rotate(Vector3.up * 5);

        // scale the object to 110% of its previous scale, on each frame
        //transform.localScale += new Vector3(0.1F, 0.1F, 0.1F);

        // move, rotate and scale on every frame
        transform.position += transform.forward * 0.01f;
        transform.Rotate(Vector3.up * 25);
        transform.localScale += new Vector3(0.01F, 0.01F, 0.01F);
    }
}
