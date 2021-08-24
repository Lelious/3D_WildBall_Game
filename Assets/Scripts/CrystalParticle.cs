using UnityEngine;

public class CrystalParticle : MonoBehaviour
{
    [SerializeField] private ParticleSystem crystalPartical;
    [SerializeField] private ParticleSystem crystalDeathPartical;

    public void CrystalPartical()
    {
        crystalPartical.Stop();
        crystalDeathPartical.Play();
    }
}
