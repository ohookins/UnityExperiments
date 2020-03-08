using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Tooltip("This needs to be a prefab not already in the scene," +
        " otherwise the original cube is deleted and cannot be spawned anymore by this script.")]
    public GameObject theCube;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnACube", 1.0f, 5.0f);
    }

    void SpawnACube()
    {
        Instantiate(theCube, transform.position, transform.rotation);
    }
}
