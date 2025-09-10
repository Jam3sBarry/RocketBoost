using UnityEngine;

public class Rightrotationunlockitem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Movement movementScript = other.GetComponent<Movement>();

        if (movementScript != null)
        {
            movementScript.UnlockRightRotation();                         // Enable right rotation
            movementScript.ShowCollectibleMessage("Left rotation unlocked!"); // Show only this message
            Destroy(gameObject);                                          // Remove the collectible
        }
    }
}
