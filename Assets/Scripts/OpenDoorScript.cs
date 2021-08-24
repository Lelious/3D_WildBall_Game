using UnityEngine;

public class OpenDoorScript : MonoBehaviour
{
    //[SerializeField] GameObject EButton;
    [SerializeField] GameObject floatTextOpenGate;
    [SerializeField] GameObject closedGate;
    [SerializeField] Animator anim;
    private bool isOpened = false;
    private bool isStayInZone = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Ball") && isOpened == false)
        {
            //EButton.SetActive(true);
            floatTextOpenGate.gameObject.SetActive(true);
            isStayInZone = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name.Contains("Ball"))
        {
            floatTextOpenGate.gameObject.SetActive(false);
            //EButton.SetActive(false);
            isStayInZone = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isStayInZone && closedGate.activeSelf == false)
        {
            OpenGate();
        }
    }
    public void OpenGate()
    {
        isStayInZone = false;
        anim.SetBool("isOpened", true);
        isOpened = true;
        floatTextOpenGate.gameObject.SetActive(false);
        //EButton.SetActive(false);
    }
}
