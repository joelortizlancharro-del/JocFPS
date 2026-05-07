using UnityEngine;

public class Target : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            Debug.Log("Diana impactada (Trigger)");

            ScoreManager.instance.AddPoint();

            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}