using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LastCinematicScript : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Camera cinematicCamera;
    [SerializeField] private Animator anim;
    [SerializeField] private Animator winAnim;
    [SerializeField] private GameObject winBall;
    [SerializeField] private GameObject wheelBall;
    [SerializeField] private AudioClip errorClip;
    [SerializeField] private AudioClip signalAlarm;
    [SerializeField] private AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Ball"))
        {
            cinematicCamera.gameObject.SetActive(true);
            mainCamera.gameObject.SetActive(false);
            wheelBall.SetActive(false);
            winBall.SetActive(true);
            audioSource.PlayOneShot(signalAlarm);
            StartCoroutine(ErrorAlarm());
            StartCoroutine(WinFade());
            StartCoroutine(End());
        }
    }
    private IEnumerator WinFade()
    {
        yield return new WaitForSeconds(1);
        anim.SetBool("isWin", true);
    }
    private IEnumerator ErrorAlarm()
    {
        yield return new WaitForSeconds(1);
        audioSource.PlayOneShot(errorClip);      
    }

    private IEnumerator End()
    {
        yield return new WaitForSeconds(7);
        winAnim.SetBool("isFade", true);
    }

}
