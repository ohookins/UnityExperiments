using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    string myText = "Game Started";

    // Start is called before the first frame update
    void Start()
    {
        messenger();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void messenger()
    {
        Debug.Log(myText);
    }
}
