using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private GameObject sphere;
    private Color sphereColor;

    void OnCollisionEnter(Collision collision)
    {
        // Check if the colliding object is a sphere
        if (collision.gameObject.tag == "Sphere")
        {
            // Get the sphere object
            sphere = collision.gameObject;

            // Get the sphere's material color
            sphereColor = sphere.GetComponent<Renderer>().material.color;

            // Change the cube's material color to the sphere's color
            GetComponent<Renderer>().material.color = sphereColor;
        }
    }
}