using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AxeColliderEnter : MonoBehaviour
{
    public Animator anim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Ball"))
        {
            anim.SetBool("isDead", true);
            StartCoroutine(DeathCoroutine());
        }
    }
    public IEnumerator DeathCoroutine()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
