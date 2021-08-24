using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTextEnable : MonoBehaviour
{
    [SerializeField] private GameObject text;
    public void ShowText()
    {
        text.SetActive(true);
    }
}
