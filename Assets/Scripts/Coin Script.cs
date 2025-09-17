using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public AudioClip collectSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (collectSound != null)
            {
                AudioSource.PlayClipAtPoint(collectSound, Camera.main.transform.position);
            }

            FindAnyObjectByType<ScoreManager>().AddPoint();
            Debug.Log("Item collected");
            Destroy(gameObject);
        }
    }
}
