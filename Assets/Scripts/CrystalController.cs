using UnityEngine;

public class CrystalController : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private GameObject crystal;
    [SerializeField] private GameObject closedDoor;
    [SerializeField] private GameObject openedDoor;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Ball"))
        {
            openedDoor.SetActive(true);
            closedDoor.SetActive(false);
            anim.SetBool("isCatched", true);
        }
    }
}
