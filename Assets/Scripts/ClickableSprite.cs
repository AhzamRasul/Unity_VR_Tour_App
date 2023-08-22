using UnityEngine;
using System.Collections;

public class ClickableSprite : MonoBehaviour
{
    public Transform cameraTransform;
    public Transform destinationPoint;
    public AudioSource clickSound; // Reference to the AudioSource component for the click sound

    private bool isTeleporting = false;

    private void OnMouseDown()
    {
        if (!isTeleporting)
        {
            StartCoroutine(TeleportCamera());
        }
    }

    private IEnumerator TeleportCamera()
    {
        isTeleporting = true;

        if (clickSound != null)
        {
            clickSound.Play(); // Play the click sound
        }

        yield return new WaitForSeconds(0.5f);

        cameraTransform.position = destinationPoint.position;

        isTeleporting = false;
    }
}
