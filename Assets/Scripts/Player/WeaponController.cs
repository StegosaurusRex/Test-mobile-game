using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class WeaponController : MonoBehaviour, ISaveable
{
   [SerializeField]private Transform firePoint;
   [SerializeField]private GameObject bulletPrefab;
    [SerializeField]private int bulletCount = 1000; // Number of bullets available
  [SerializeField]private AudioClip shootSound; // Sound for shooting
    [SerializeField]private float bulletSpeed = 10f; // Speed of the bullet
    [SerializeField]private TextMeshProUGUI bulletCountText;

    public void LoadData(SaveObject data)
    {
        this.bulletCount=data.bulletCount;

    }

    public void SaveData(SaveObject data)
    {
        data.bulletCount=this.bulletCount;
    }
void Start()
{
    bulletCountText.SetText("Количество пуль "+ bulletCount);
}
    public void Shoot()
{
    if (bulletCount > 0)
    {
        AudioSource.PlayClipAtPoint(shootSound, firePoint.position); // Play shooting sound at fire point

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); // Instantiate the bullet
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); // Get the Rigidbody component of the bullet

        rb.velocity = -firePoint.right * bulletSpeed; // Make the bullet fly in the direction of the fire point

        Destroy(bullet, 3f); // Destroy the bullet after 3 seconds

        bulletCount--; // Decrease the bullet count
        bulletCountText.SetText("Количество пуль "+ bulletCount);
    }
    
}



}
