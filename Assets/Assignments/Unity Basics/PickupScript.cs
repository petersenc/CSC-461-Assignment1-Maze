using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(audioSource.clip, transform.position);
            Destroy(gameObject);
        }
    }
}
