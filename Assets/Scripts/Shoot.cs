using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float force = 20f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * force, ForceMode.Impulse);

        Debug.Log("Disparo realizado");
    }
}