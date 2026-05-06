using UnityEngine;

public class Target : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Bullet"))
    {
        Debug.Log("Diana impactada (Trigger)");

        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
}