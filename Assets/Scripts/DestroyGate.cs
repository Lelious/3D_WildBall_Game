using UnityEngine;

public class DestroyGate : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip gateOpeningSound;
    public void DestroyOpenedGate()
    {
        gameObject.SetActive(false);
    }
    private void GateOpening()
    {
        audioSource.PlayOneShot(gateOpeningSound);
    }
}
