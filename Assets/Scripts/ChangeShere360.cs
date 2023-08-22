using System.Collections.Generic;
using UnityEngine;

public class ChangeShere360 : MonoBehaviour
{
    bool changing = false;

    // Dictionary to map sphere identifiers to their transforms
    public Dictionary<string, Transform> spheres = new Dictionary<string, Transform>();

    // Register spheres and their identifiers
    public void RegisterSphere(string identifier, Transform sphereTransform)
    {
        spheres[identifier] = sphereTransform;
    }

    // This function will be called when the button is clicked
    public void OnChangeSphereButtonClick(string sphereIdentifier)
    {
        if (spheres.TryGetValue(sphereIdentifier, out Transform nextSphereTransform))
        {
            // Call the ChangeSphere function with the next sphere's Transform
            ChangeSphere(nextSphereTransform);
        }
        else
        {
            Debug.LogWarning("Sphere with identifier " + sphereIdentifier + " not found.");
        }
    }

    // The main function to change the sphere
    public void ChangeSphere(Transform nextSphere)
    {
        if (nextSphere != null && !changing)
        {
            // Move the camera to the position of the next sphere
            Camera.main.transform.parent.position = nextSphere.position;
            // Optionally, you can also look at the center of the sphere:
            Camera.main.transform.parent.LookAt(nextSphere.GetComponent<SphereCollider>().bounds.center);
        }
    }
}
