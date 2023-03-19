using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseActionDetection : MonoBehaviour
{
    void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        Debug.Log("Mouse is over GameObject.");
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            OnMouseOver();
    }
}
