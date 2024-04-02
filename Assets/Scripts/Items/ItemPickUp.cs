using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public AudioClip pickupSound; // Reference to the audio clip for pickup sound
    private AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Get the AudioSource component attached to the same GameObject
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Play the pickup sound
            if (pickupSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(pickupSound);
            }

            Debug.Log("Item picked up");
            Destroy(gameObject); // Destroy the item after picking it up
        }
    }
}
