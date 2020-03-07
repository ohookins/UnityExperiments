using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    string myText = "Game Started";
    int answer;

    // Start is called before the first frame update
    void Start()
    {
        messenger();
        answer = AddNumbers(5, 3);
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void messenger()
    {
        Debug.Log(myText);
    }

    int AddNumbers(int num1, int num2)
    {
        return num1 + num2;
    }
}
