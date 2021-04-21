using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{

    void OnMouseDown()                                                  // is executed if cube is clicked
    {
        this.GetComponent<Renderer>().material.color = RandomColor();   // sets material color to random color
    }

    Color RandomColor()                                                 // Generates a random color
    {
        return new Color(Random.value, Random.value, Random.value);     
    }
}
