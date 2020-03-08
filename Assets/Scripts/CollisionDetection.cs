using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
	// Use this for initialization	
	void Start()
	{

	}
	// Update is called once per frame
	void Update()
	{

	}

    void OnCollisionEnter(Collision info)
    {
        if (info.gameObject.name == "Plane")
        {
            Debug.Log("Collision Detected");
            Destroy(this.gameObject);
        }
    }
    void OnTriggerEnter(Collider info)
    {
        if (info.gameObject.name == "Plane")
        {
            Debug.Log("Trigger Detected");
        }
    }
}
