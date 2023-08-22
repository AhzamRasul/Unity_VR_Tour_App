using UnityEngine;

public class CameraTeleportLocation : MonoBehaviour
{
    // The reference to the camera that will teleport
    public Transform cameraTransform;

    // Method to handle the teleportation
    public void TeleportCamera()
    {
        // Move the camera to the position of this GameObject
        cameraTransform.position = transform.position;
    }
}

