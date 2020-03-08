using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityAI : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject explosion;
    public float speed = 0.05f;
    float range;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        range = Vector3.Distance(thePlayer.transform.position, transform.position);
        if (range < 40)
        {
            transform.LookAt(thePlayer.transform.position);
        }
        if (range < 30 && range > 15)
        {
            transform.position += transform.forward * speed;
        }
        if (range < 12)
        {
            transform.position += transform.forward * -speed;

        }
        if (range < 6)
        {
            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
