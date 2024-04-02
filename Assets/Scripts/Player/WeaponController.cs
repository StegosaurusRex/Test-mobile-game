using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
   [SerializeField]private Transform firePoint;
   [SerializeField]private GameObject bulletPrefab;

  public AudioClip shootSound; // Sound for shooting
    public float bulletSpeed = 10f; // Speed of the bullet
    

    public void Shoot()
{
    AudioSource.PlayClipAtPoint(shootSound, firePoint.position); // Play shooting sound at fire point

    GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Instantiate the bullet
    Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); // Get the Rigidbody component of the bullet

    rb.velocity = -firePoint.right * bulletSpeed; // Make the bullet fly in the direction of the fire point

    Destroy(bullet, 3f); // Destroy the bullet after 3 seconds

}


}
