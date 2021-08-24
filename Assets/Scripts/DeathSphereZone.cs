using UnityEngine;

public class DeathSphereZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Sphere"))
        {
            other.transform.position = other.transform.position + new Vector3(0, 7.5f, 0);
        }
    }
}
