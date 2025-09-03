using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        // Check if the object that entered the trigger is the player
        if (other.CompareTag("Player"))
        {
            // Try to get the Movement script from the player
            Movement movementScript = other.GetComponent<Movement>();
            if (movementScript != null)
            {
                // Enable left rotation and show the unlock message
                movementScript.ShowUnlockMessage();
            }

            // Destroy the collectible item
            Destroy(gameObject);
        }
    }
}
