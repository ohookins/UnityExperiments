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
			Destroy(gameObject);
		}

		if (info.gameObject.name == "Sphere")
		{
			gameObject.GetComponent<Rigidbody>().AddForce(0, 300, 0);
		}
	}
}
