using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingSphere : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0.2f, 0); //rotates the GameObject of which Sphere is a child by 0.2 degrees on Update
    }
}
