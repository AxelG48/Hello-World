using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text newText;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            newText.text = "Hello, my name is Alex Grant!";
        }
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
