using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCreator : MonoBehaviour
{
    public int numberOfSpheres;
    public GameObject spherePrefab;

    void Start()
    {
        // Create initial spheres
        for (int i = 0; i < numberOfSpheres; i++)
        {
            CreateSphere();
        }
    }

    void CreateSphere()
    {
        // Instantiate a new sphere prefab
        GameObject newSphere = Instantiate(spherePrefab);

        // Transform the new sphere to a random position
        newSphere.transform.position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0.0f);

        // Set the new sphere's material color to random
        newSphere.GetComponent<Renderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }
}