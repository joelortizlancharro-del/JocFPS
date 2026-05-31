using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float force = 20f;

    public float fireRate = 0.8f; // tiempo entre disparos
    private float nextTimeToFire = 0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time >= nextTimeToFire)
        {
            ShootBullet();
            nextTimeToFire = Time.time + fireRate;
        }
    }

    void ShootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = firePoint.forward * force;

        Debug.Log("Disparo realizado");
    }
}