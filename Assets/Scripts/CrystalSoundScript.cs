using UnityEngine;

public class CrystalSoundScript : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip crystalCatchStartSound;
    [SerializeField] AudioClip crystalCatchSound;
    [SerializeField] AudioClip crystalCatchAttentionSound;

    private void CrystalStartCatch()
    {
        audioSource.PlayOneShot(crystalCatchStartSound);
    }

    private void CrystalCatch()
    {
        audioSource.PlayOneShot(crystalCatchSound);
        audioSource.PlayOneShot(crystalCatchAttentionSound);
    }
}
