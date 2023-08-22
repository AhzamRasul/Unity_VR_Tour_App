using UnityEngine;

public class CameraRotator : MonoBehaviour
{
    public float rotationSpeed = 5.0f;

    private void Update()
    {
        // Check for touch input
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;
            RotateCamera(new Vector3(-touchDeltaPosition.y, touchDeltaPosition.x, 0) * rotationSpeed);
        }

        // Check for mouse input
        if (Input.GetMouseButton(0))
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
            RotateCamera(new Vector3(-mouseY, mouseX, 0) * rotationSpeed);
        }
    }

    private void RotateCamera(Vector3 rotation)
    {
        // Rotate the camera based on the input
        transform.Rotate(rotation);
    }
}
