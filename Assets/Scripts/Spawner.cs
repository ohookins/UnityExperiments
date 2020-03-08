using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Tooltip("This needs to be a prefab not already in the scene," +
        " otherwise the original cube is deleted and cannot be spawned anymore by this script.")]
    public GameObject theCube;
    GameObject newObject;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnACube());
    }

    IEnumerator SpawnACube()
    {
        while (true)
        {
            newObject = Instantiate(theCube, transform.position, transform.rotation);
            Destroy(newObject, 1.0f);
            yield return new WaitForSeconds(Random.Range(0.1f, 5.0f));
        }
    }
}
