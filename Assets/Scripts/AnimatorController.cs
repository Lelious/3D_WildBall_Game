using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void ChangeAnimation()
    {
        anim.SetInteger("Random",Random.Range(0, 3));
    }
}
