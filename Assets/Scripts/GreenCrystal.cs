using UnityEngine;

public class GreenCrystal : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject deathPlatform;
    [SerializeField] private GameObject normalPlatform;
    [SerializeField] private AudioSource audioSourse;
    [SerializeField] private AudioClip crystalCatchSound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Ball"))
        {
            normalPlatform.SetActive(true);
            deathPlatform.SetActive(false);
            anim.SetBool("isGreenCatched", true);
        }
    }
    private void CrystalCatch()
    {
        audioSourse.PlayOneShot(crystalCatchSound);
    }
}
