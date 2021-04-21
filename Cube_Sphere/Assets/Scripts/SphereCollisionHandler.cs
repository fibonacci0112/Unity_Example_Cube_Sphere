using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCollisionHandler : MonoBehaviour
{
    void OnTriggerEnter(Collider col)                                       // executed when cube hits Sphere
    {
        this.GetComponent<Renderer>().material.color = col.gameObject.GetComponent<Renderer>().material.color;
                                                                            // Changes Sphere Color to Cube Color
    }
}
