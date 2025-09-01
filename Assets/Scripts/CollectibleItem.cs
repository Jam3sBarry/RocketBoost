using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Item collected");

            // Enable left rotation
            Movement movementScript = other.GetComponent<Movement>();
            if (movementScript != null)
            {
                movementScript.canRotateLeft = true;
            }

            Destroy(gameObject);
        }
    }
}
